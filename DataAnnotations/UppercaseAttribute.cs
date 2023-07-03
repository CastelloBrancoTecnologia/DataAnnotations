﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.DataAnnotations;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class UpperCaseAttribute : Attribute
{
    public UpperCaseAttribute() : base()
    {
    }
}

