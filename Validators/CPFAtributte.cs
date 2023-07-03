using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CBT.DataAnnotations.Resources;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class CPFAttribute : ValidationAttribute
{
    public CPFAttribute() : base(SharedResources.CPFInválido) { }

    public CPFAttribute(string ErrorMessage) : base (ErrorMessage) { }

    public bool AllowOnlyDigits { get; set; } = true;
    public bool AllowEmpty { get; set; } = true;
    public bool AllowMasked { get; set; } = true;

    /// <summary>
    /// Valida se um cpf é válido
    /// </summary>
    /// <param name="cpf"></param>
    /// <returns></returns>
    public static bool ValidaCPF(string cpf)
    {

        // ou  000.000.000-01 ou 00000000001
        // ou  12345678901234    12345678901
        if (cpf.Length != 14 && cpf.Length != 11)
            return false;

        cpf = cpf.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);

        if (cpf.Length != 11)
            return false;

        for (int i = 0; i < 11; i++)
        {
            if (!char.IsDigit(cpf[i]))
                return false;
        }

        bool igual = true;

        for (int i = 1; i < 11 && igual; i++)
            if (cpf[i] != cpf[0])
                igual = false;

        if (igual || cpf == "12345678909")
            return false;

        int[] numeros = new int[11];

        for (int i = 0; i < 11; i++)
            numeros[i] = int.Parse(cpf[i].ToString());

        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (10 - i) * numeros[i];

        int resultado = soma % 11;

        if (resultado == 1 || resultado == 0)
        {
            if (numeros[9] != 0)
                return false;
        }
        else if (numeros[9] != 11 - resultado)
            return false;

        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += (11 - i) * numeros[i];

        resultado = soma % 11;

        if (resultado == 1 || resultado == 0)
        {
            if (numeros[10] != 0)
                return false;
        }
        else
            if (numeros[10] != 11 - resultado)
                return false;

        return true;
    }

    /// <summary>
    /// Validação 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
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

        if ( (stringValue.Length == 14 && AllowMasked) || 
             (stringValue.Length == 11 && AllowOnlyDigits) ) 
        {
            return CPFAttribute.ValidaCPF(stringValue); 
        }
        else
        {
            return false;
        }
    }
}
