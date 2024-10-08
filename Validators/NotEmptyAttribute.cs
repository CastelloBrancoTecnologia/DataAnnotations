using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class NotEmptyAttribute : ValidationAttribute
{
    public NotEmptyAttribute() : base(SharedResources.NotEmptyErrorMessage)
    {
    }

    public NotEmptyAttribute(string ErrorMessage) : base(ErrorMessage) { }

    public bool AllowEmptyValue { get; set; } = false;

    public object? EmptyValue { get; set; }

    public bool AllowEmptyStrings { get; set; } = true;

    public override bool IsValid(object? value)
    {
        if (value == null)
            return false;

        if (!AllowEmptyValue && EmptyValue == value)
            return false;

        string? stringValue = value as string;

        if (!AllowEmptyStrings)
            return ! string.IsNullOrWhiteSpace(stringValue);

        return true;
    }
}

