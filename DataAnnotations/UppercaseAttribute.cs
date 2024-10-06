using System;
using System.Collections.Generic;
using System.Text;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class UpperCaseAttribute : Attribute
{
    public UpperCaseAttribute() : base()
    {
    }
}

