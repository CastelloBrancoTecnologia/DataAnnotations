using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using CastelloBranco.DataAnnotations.Resources;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class CNPJAttribute : ValidationAttribute
{
	private static readonly int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
	private static readonly int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

	public CNPJAttribute() : base(errorMessage:SharedResources.CNPJInválido) { }

	public CNPJAttribute(string ErrorMessage) : base(ErrorMessage) { }

	public bool AllowOnlyDigits { get; set; } = true;
	public bool AllowEmpty { get; set; } = true;
	public bool AllowMasked { get; set; } = true;

	public static bool ValidaCnpj(string cnpj)
	{
		int soma;
		int resto;

		string digito;
		string tempCnpj;

		// ou  00.000.000/0001-01 ou 00000000000101
		// ou  123456789012345678    12345678901234 
		if (cnpj.Length != 18 && cnpj.Length != 14) 
			return false;

		cnpj = cnpj.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);

		if (cnpj.Length != 14) 
			return false;

		for (int i = 0; i < 14; i++)
		{
			if (!char.IsDigit(cnpj[i]))
				return false;
		}

		bool igual = true;

		for (int i = 1; i < 14 && igual; i++)
			if (cnpj[i] != cnpj[0])
				igual = false;

		if (igual || cnpj == "12345678901239")
			return false;

		tempCnpj = cnpj[..12];

		soma = 0;

		for (int i = 0; i < 12; i++)
		{
			soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
		}

		resto = (soma % 11);

		if (resto < 2)
			resto = 0;
		else
			resto = 11 - resto;

		digito = resto.ToString();

		tempCnpj += digito;

		soma = 0;

		for (int i = 0; i < 13; i++)
			soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

		resto = (soma % 11);

		if (resto < 2)
			resto = 0;
		else
			resto = 11 - resto;

		digito += resto.ToString();

		return cnpj.EndsWith(digito);
	}

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

        if ((stringValue.Length == 18 && AllowMasked) ||
			 (stringValue.Length == 14 && AllowOnlyDigits))
		{
			return CNPJAttribute.ValidaCnpj(stringValue);
		}
		else
		{
			return false;
		}
	}
}
