using System;
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
    /// A <see cref="EAVAttributeBase"/> is the composition of an <see cref="EAVAttributeBase"/>
    /// instance and an <see cref="EAVEntityBase"/> instance.
    /// <br/>
    /// The <see cref="EAVValueBase"/> stores the actual value as a raw string. The
    /// <see cref="IEAVValueConverter{T}"/> implementations will convert those values
    /// accordingly to the attribute's <see cref="EAVAttributeBase.ValueKind"/> property.
    /// </summary>
    public abstract class EAVValueBase
    {
        /// <summary>
        /// The value as stored in raw format.
        /// </summary>
        public string? RawValue { get; set; }

        /// <summary>
        /// The attribute for witch the value is set
        /// </summary>
        public EAVAttributeBase? Attribute { get; set; }

        /// <summary>
        /// The entity for witch the value is set
        /// </summary>
        public EAVEntityBase? Entity { get; set; }
    }
}
