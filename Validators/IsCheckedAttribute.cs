using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class IsCheckedAttribute : ValidationAttribute
{
    public IsCheckedAttribute () : base(SharedResources.IsCheckedErrorMessage)
    {
    }

    public IsCheckedAttribute (string ErrorMessage) : base(ErrorMessage) { }

    public override bool IsValid(object? value)
    {
        if (value == null || value is not bool)
            return false;

        return (bool) value;
    }
}

