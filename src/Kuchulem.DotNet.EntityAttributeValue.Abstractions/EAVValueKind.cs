using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// The types of values.<br/>
    /// Each type will comme with specific validators and converters
    /// </summary>
    public enum EAVValueKind
    {
        /// <summary>
        /// No type specified, will fallback to <see cref="EAVValueKind.String"/>
        /// </summary>
        None = 0,
        /// <summary>
        /// The stored value will be an <see cref="int"/> or a <see cref="long"/> (16 or 32 bits number).
        /// </summary>
        Integer = 1,
        /// <summary>
        /// The value will be a boolean (1 bit number).
        /// </summary>
        Boolean = 2,
        /// <summary>
        /// The value will be considered a string.
        /// </summary>
        String = 3,
        /// <summary>
        /// The value will refer to an entity, meaning a model from the application.<br/>
        /// An <see cref="IEAVValueConverter{T}"/> implementation will be responsible to
        /// fetch the right entity. See <see cref="IEAVValueConverter{T}"/> for more
        /// information.
        /// </summary>
        Entity = 5,
        /// <summary>
        /// The value is a to be treated as a DateTime
        /// </summary>
        DateTime = 6,
        /// <summary>
        /// The value will be a <see cref="float"/> or <see cref="double"/> (32 bits or 64 bits)
        /// </summary>
        Number = 7,
    }
}
