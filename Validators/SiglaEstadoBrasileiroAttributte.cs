using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

using CBT.DataAnnotations.Resources;
using CBT.Singletons;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class SiglaEstadoBrasileiro : ValidationAttribute
{
    public SiglaEstadoBrasileiro() : base(SharedResources.EstadoInvalido)
    {
    }

    public bool AllowEmpty { get; set; }

    public SiglaEstadoBrasileiro(string ErrorMessage) : base(ErrorMessage) { }

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

        return EstadosDoBrasil.Estados.Any (s => s.Sigla.ToUpper () == stringValue.ToUpper());
    }
}
