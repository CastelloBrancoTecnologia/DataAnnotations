using System;
using System.Collections.Generic;
using System.Text;

namespace CastelloBranco.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class MaskAttribute : Attribute
{
    public string Mask { get; set; }

    public MaskAttribute(string mask) : base()
    {
        Mask = mask;    
    }
}

