using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CBT.DataAnnotations.Resources;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class NotEmpty : ValidationAttribute
{
    public NotEmpty() : base(SharedResources.NotEmptyErrorMessage)
    {
    }

    public NotEmpty(string ErrorMessage) : base(ErrorMessage) { }

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

