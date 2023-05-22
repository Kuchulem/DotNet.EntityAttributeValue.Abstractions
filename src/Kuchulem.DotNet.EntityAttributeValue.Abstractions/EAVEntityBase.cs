using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Abstract class that must be extended by entities that should match the EAV pattern.<br/>
    /// <br/>
    /// An entity contains 0 to n <see cref="EAVValueBase"/>. Each <see cref="EAVValueBase"/> is the
    /// composition of an <see cref="EAVEntityBase"/> and an <see cref="EAVAttributeBase"/>.
    /// </summary>
    public abstract class EAVEntityBase
    {
        /// <summary>
        /// The list of values that defines the entity.
        /// </summary>
        public virtual IEnumerable<EAVValueBase> Values { get; set; } = Enumerable.Empty<EAVValueBase>();
    }
}
