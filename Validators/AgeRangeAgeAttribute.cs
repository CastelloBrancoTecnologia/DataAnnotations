using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class AgeRangeAttribute : ValidationAttribute
{
    public AgeRangeAttribute() : base(SharedResources.Idadenãopermitida)
    {
    }

    public AgeRangeAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public bool AllowEmpty { get; set; }

    public int MinimunAge { get; set; } = 18;

    public int MaximunAge { get; set; } = 120;

    public override bool IsValid(object? value)
    {
        if (value == null)
            return AllowEmpty;

        if (value is DateTimeOffset offset)
        {
            DateTimeOffset dateValue;

            try
            {
                dateValue = offset;
            }
            catch
            {
                return false;
            }

            int idade = DateTimeOffset.UtcNow.Year - dateValue.Year;

            return (idade >= MinimunAge && idade <= MaximunAge);
        }
        else if (value is DateTime time)
        {
            DateTime dateValue;

            try
            {
                dateValue = time;
            }
            catch
            {
                return false;
            }

            DateTimeOffset today = DateTimeOffset.UtcNow;

            int idade = (today.Year - dateValue.Year - 1) +
                (((today.Month > dateValue.Month) ||
                ((today.Month == dateValue.Month) && (today.Day >= dateValue.Day))) ? 1 : 0);

            return (idade >= MinimunAge && idade <= MaximunAge);
        }
        else
        {
            return false;
        }
    }
}

