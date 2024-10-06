using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class FullNameAttribute : ValidationAttribute
{
    public FullNameAttribute() : base(SharedResources.NomeCompletoInválidoErrorMessage)
    {
    }

    public FullNameAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public override bool IsValid(object? value)
    {
        if (value == null)
            return false;

        string? stringValue = value as string;

        if (string.IsNullOrWhiteSpace(stringValue))
        {
            return false;
        }

        string [] nomes = stringValue.Split(' ');

        if (nomes.Length < 2)
        {
            return false;
        }

        foreach (string s in nomes)
        {
            if (s.Trim().Length < 2)
            {
                return false;
            }
        }

        return true;
    }
}
