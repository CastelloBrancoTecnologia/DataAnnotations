using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class DateTimeOffsetAttribute : ValidationAttribute
{
    public DateTimeOffsetAttribute() : base(SharedResources.DataInválidaErrorMessage)
    {
    }

    public DateTimeOffsetAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public bool AllowEmpty { get; set; }

    public DateTimeOffset? MinDate { get; set; } = DateTimeOffset.MinValue;
    public DateTimeOffset? MaxDate { get; set; } = DateTimeOffset.MaxValue;

    public bool AllowWeekends { get; set; } = true;
    public override bool IsValid(object? value)
    {
        if (value == null)
            return AllowEmpty;

        DateTimeOffset dt;

        if (value is string)
        {
            if (value is not string stringValue)
            {
                return false;
            }

            if (stringValue.Trim().Length == 0)
            {
                return AllowEmpty;
            }

            if (!DateTimeOffset.TryParse(stringValue, out dt))
            {
                return false;
            }
        }
        else if (value is DateTimeOffset offset)
        {
            dt = offset;
        }
        else if (value is DateTime time)
        {
            dt = new DateTimeOffset(time);
        }
        else if (value is DateOnly only)
        {
            dt = new DateTimeOffset(only.ToDateTime(new TimeOnly(0, 0, 0)));
        }
        else
        {
            return false;
        }

        if (MinDate.HasValue && dt < MinDate)
        {
            return false;
        }

        if (MaxDate.HasValue && dt > MaxDate)
        {
            return false;
        }

        if (!AllowWeekends && (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday))
        {
            return false;
        }

        return true;
    }
}

