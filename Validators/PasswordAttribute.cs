using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

using CBT.DataAnnotations.Resources;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class PasswordAttribute : ValidationAttribute
{
    public PasswordAttribute() : base()
    {
    }

    public bool RequireUppercaseLetter { get; set; } = false;
    public bool RequireLowercaseLetter { get; set; } = false;
    public bool RequireLetter { get; set; } = true;
    public bool RequireDigit { get; set; } = true;
    public bool RequireSimbol { get; set; } = true;
    public bool DontAllowAscendentSequence { get; set; } = true;
    public bool DontAllowDescendentSequence { get; set; } = true;
    public bool DontAllowRepeats { get; set; } = true;
    public int MinimunLength { get; set; } = 6;
    public int MaximunLength { get; set; } = 16;
    public string ConfirmationPasswordPropertyName { get; set; } = string.Empty;

    public override bool RequiresValidationContext
    {
        get
        {
            return true;
        }
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not string senha)
            throw new InvalidCastException();

        if (string.IsNullOrWhiteSpace(senha))
            return new ValidationResult(SharedResources.NotEmptyErrorMessage);

        senha = senha.Trim(); // Remove spaces

        if (RequireUppercaseLetter)
        {
            if (!senha.Any(ch => char.IsUpper(ch)))
            {
                return new ValidationResult(SharedResources.RequireUppercaseLetterErrorMessage);
            }
        }

        if (RequireLowercaseLetter)
        {
            if (!senha.Any(ch => char.IsLower(ch)))
            {
                return new ValidationResult(SharedResources.RequireLowercaseLetterErrorMessage);
            }
        }

        if (RequireLetter)
        {
            if (!senha.Any(ch => char.IsLetter(ch)))
            {
                return new ValidationResult(SharedResources.RequireLetterErrorMessage);
            }
        }

        if (RequireDigit)
        {
            if (!senha.Any(ch => char.IsDigit(ch)))
            {
                return new ValidationResult(SharedResources.RequireDigitErrorMessage);
            }
        }

        if (RequireSimbol)
        {
            if (!senha.Any(ch => !char.IsLetter(ch) &&
                                  !char.IsDigit(ch) &&
                                  !char.IsControl(ch) &&
                                  !char.IsWhiteSpace(ch)))
            {
                return new ValidationResult(SharedResources.RequireSymbolErrorMessage);
            }
        }

        if (DontAllowRepeats)
        {
            if (!(!senha.Where((c, i) => i >= 2 && senha[i - 1] == c && senha[i - 2] == c).Any()))
            {
                return new ValidationResult(SharedResources.DontAllowRepeatsErrorMessage);
            }
        }

        if (DontAllowAscendentSequence)
        {
            if (!(!senha.Where((c, i) => i >= 2 && ((senha[i - 1]) - 1) == c && ((senha[i - 2]) - 2) == c).Any()))
            {
                return new ValidationResult(SharedResources.DontAllowAscendentSequenceErrorMessage);
            }
        }

        if (DontAllowDescendentSequence)
        {
            if (!(!senha.Where((c, i) => i >= 2 && ((senha[i - 1]) + 1) == c && ((senha[i - 2]) + 2) == c).Any()))
            {
                return new ValidationResult(SharedResources.DontAllowDescendentSequenceErrorMessage);
            }
        }

        if (senha.Length < MinimunLength)
        {
            return new ValidationResult(SharedResources.PasswordMinimunLengthErrorMessage);
        }

        if (senha.Length > MaximunLength)
        {
            return new ValidationResult(SharedResources.PasswordMaximunLengthErrorMessage);
        }

        if (!string.IsNullOrWhiteSpace(ConfirmationPasswordPropertyName))
        {
            PropertyInfo? otherPropertyInfo = validationContext.ObjectType.GetProperty(ConfirmationPasswordPropertyName);

            if (otherPropertyInfo == null)
            {
                throw new Exception ($"propriedade da confirmacao da senha {ConfirmationPasswordPropertyName} nao definido.\r\n");
            }

            object? otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            if (!Equals(value, otherPropertyValue))
            {
                return new ValidationResult(SharedResources.AsSenhasNãoSâoIguais);
            }
        }

        return ValidationResult.Success;
    }
}

