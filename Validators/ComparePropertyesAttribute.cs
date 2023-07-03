using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using CBT.DataAnnotations.Resources;

namespace System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
//[SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Justification = "This attribute is designed to be a base class for other attributes.")]
public class CompareTwoPropertiesAttribute : CompareAttribute
{
    public CompareTwoPropertiesAttribute(string otherProperty) : base(otherProperty)
    {
    }
}
