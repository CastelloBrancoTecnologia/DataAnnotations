using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Reflection;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class CEP : ValidationAttribute
{
    public CEP() : base(SharedResources.CEPInválido)
    {
    }

    public CEP(string ErrorMessage) : base(ErrorMessage) { }

    public bool OnlyDigits { get; set; }
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

        if (stringValue.Length == 8)
        {
            if ((char.IsDigit(stringValue[0])) &&
                (char.IsDigit(stringValue[1])) &&
                (char.IsDigit(stringValue[2])) &&
                (char.IsDigit(stringValue[3])) &&
                (char.IsDigit(stringValue[4])) &&
                (char.IsDigit(stringValue[5])) &&
                (char.IsDigit(stringValue[6])) &&
                (char.IsDigit(stringValue[7])))
            {
                return true;
            }
        }
        else if (stringValue.Length == 9 && ! OnlyDigits)
        {
            if ((char.IsDigit(stringValue[0])) && 
                (char.IsDigit(stringValue[1])) &&
                (char.IsDigit(stringValue[2])) &&
                (char.IsDigit(stringValue[3])) &&
                (char.IsDigit(stringValue[4])) &&
                (stringValue[5] == '-') &&
                (char.IsDigit(stringValue[6])) &&
                (char.IsDigit(stringValue[7])) &&
                (char.IsDigit(stringValue[8])) )
            {
                return true;
            }
        }

        return false;
    }
}
