using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CBT.DataAnnotations.Resources;
using CBT.Singletons;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class DDD : ValidationAttribute
{
    public DDD() : base(SharedResources.DDDInvalido)
    {
    }

    public DDD(string ErrorMessage) : base(ErrorMessage) { }

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

        if (stringValue.Length != 2)
        {
            return false;
        }

        if (! (char.IsDigit(stringValue[0])) ||
            ! (char.IsDigit(stringValue[1])) )
        {
            return false;
        }

        return DDDsDoBrasil.DDDs.Any(d => d.Ddd == stringValue);
    }
}
