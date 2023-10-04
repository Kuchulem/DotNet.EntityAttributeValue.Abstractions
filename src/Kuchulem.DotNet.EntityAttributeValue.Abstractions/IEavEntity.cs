using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Defines an entity that's part of the EAV model
    /// </summary>
    public interface IEavEntity
    {
        /// <summary>
        /// Gets the values of that entity as a list of <see cref="IEavValue"/>
        /// </summary>
        /// <returns>The values set for that entity</returns>
        IEnumerable<IEavValue> GetEavValues();
    }
}
