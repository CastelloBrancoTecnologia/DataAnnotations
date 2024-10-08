using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CastelloBranco.DataAnnotations.Resources;
using CastelloBranco.Singletons;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class CountryCodeAttribute : ValidationAttribute
{
    public CountryCodeAttribute() : base(SharedResources.DDDInvalido)
    {
    }

    public CountryCodeAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public bool AllowEmpty { get; set; }

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

        if (stringValue.Length > 4)
        {
            return false;
        }

        return WorldCountries.Countries.Any (d => d.CountryCode == stringValue);
    }
}
