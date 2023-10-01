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
    /// A <see cref="IEAVAttribute"/> is the composition of an <see cref="IEAVAttribute"/>
    /// instance and an entity instance.
    /// <br/>
    /// The <see cref="IEAVValue{TEntity, TAttribute}"/> stores the actual value as a raw string. The
    /// <see cref="IEAVValueConverter{T}"/> implementations will convert those values
    /// accordingly to the attribute's <see cref="IEAVAttribute.ValueKind"/> property.
    /// </summary>
    public interface IEAVValue<TEntity, TAttribute>
        where TEntity : class
        where TAttribute : IEAVAttribute
    {
        /// <summary>
        /// The value as stored in raw format.
        /// </summary>
        string? RawValue { get; set; }

        /// <summary>
        /// The attribute for witch the value is set
        /// </summary>
        TAttribute? Attribute { get; set; }

        /// <summary>
        /// The entity for witch the value is set
        /// </summary>
        TEntity? Entity { get; set; }
    }
}
