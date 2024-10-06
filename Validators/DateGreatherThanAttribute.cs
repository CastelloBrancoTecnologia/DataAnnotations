using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public sealed class DateTimeOffsetDateGreaterThanAttribute : ValidationAttribute
{
    readonly String _basePropertyName = "";

    public DateTimeOffsetDateGreaterThanAttribute(String basePropertyName)
        : base(SharedResources.DateTimeOffsetDateGreaterThanErrorMessage)
    {
        _basePropertyName = basePropertyName;
    }

    //Override default FormatErrorMessage Method
    public override String FormatErrorMessage(String name)
    {
        return String.Format(SharedResources.DateTimeOffsetDateGreaterThanErrorMessage, name, _basePropertyName);
    }

    //Override IsValid
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        //Get PropertyInfo Object
        PropertyInfo? basePropertyInfo = validationContext.ObjectType.GetProperty(_basePropertyName);

        //Get Value of the property
        DateTimeOffset? startDate = (DateTimeOffset?) basePropertyInfo?.GetValue(validationContext.ObjectInstance, null);

        DateTimeOffset? thisDate = (DateTimeOffset?)value;

        //Actual comparision
        if (thisDate <= startDate)
        {
            var message = FormatErrorMessage(validationContext.DisplayName);

            return new ValidationResult(message);
        }

        //Default return - This means there were no validation error
        return null;
    }
}

