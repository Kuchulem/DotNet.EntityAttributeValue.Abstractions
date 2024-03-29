﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// This abstract class must be extended by models that represents a value
    /// for an entity's attribute.
    /// <br/>
    /// A <see cref="IEavAttribute"/> is the composition of an <see cref="IEavAttribute"/>
    /// instance and an entity instance.
    /// <br/>
    /// The <see cref="IEavValue"/> stores the actual value as a raw string. The
    /// <see cref="IEavRawValueConverter"/> implementations will convert those values
    /// accordingly to the attribute's <see cref="IEavAttribute.ValueKind"/> property.
    /// </summary>
    public interface IEavValue
    {
        /// <summary>
        /// The value as stored in raw format.
        /// </summary>
        string? RawValue { get; set; }

        /// <summary>
        /// The attribute for witch the value is set
        /// </summary>
        IEavAttribute? GetEavAttribute();

        /// <summary>
        /// The entity for witch the value is set
        /// </summary>
        object GetEntity();
    }
}
