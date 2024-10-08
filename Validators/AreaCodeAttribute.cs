using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CastelloBranco.DataAnnotations.Resources;
using CastelloBranco.Singletons;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class AreaCodeAttribute : ValidationAttribute
{
    public AreaCodeAttribute() : base(SharedResources.DDDInvalido)
    {
    }

    public AreaCodeAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public bool AllowEmpty { get; set; }

    private const string BrazilCountryCode = "55";

    public string CountryCode { get; set; } = BrazilCountryCode;


    public override bool IsValid(object? value)
    {
        if (value == null)
            return AllowEmpty;

        if (value is not string stringValue)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(stringValue))
        {
            return AllowEmpty;
        }

        if (CountryCode == BrazilCountryCode && stringValue.Length != 2)
        {
            return false;
        }

        if ( (CountryCode != BrazilCountryCode) && (stringValue.Length < 2 || stringValue.Length > 3) )
        {
            return false;
        }

        if (! (char.IsDigit(stringValue[0])) ||
            ! (char.IsDigit(stringValue[1])) ||
            ! (stringValue.Length == 3 && char.IsDigit(stringValue[2])))
        {
            return false;
        }

        return (CountryCode != BrazilCountryCode) || BrazilAreaCode.AreaCodes.Any(d => d.AreaCode == stringValue);
    }
}
