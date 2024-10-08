using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CastelloBranco.DataAnnotations.Resources;
using CastelloBranco.Singletons;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class SiglaPaisAttribute : ValidationAttribute
{
    public SiglaPaisAttribute() : base(SharedResources.SiglaDoPaisInvalida)
    {
    }

    public bool AllowEmpty { get; set; }

    public SiglaPaisAttribute(string ErrorMessage) : base(ErrorMessage) { }

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

        return WorldCountries.Countries.Any (s => s.Acronym.ToUpper () == stringValue.ToUpper());
    }
}
