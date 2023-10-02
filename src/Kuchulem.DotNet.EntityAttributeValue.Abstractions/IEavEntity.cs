using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Interface to be implemented by entities that follow the
    /// EntityAttributeValue pattern.
    /// </summary>
    public interface IEavEntity
    {
        /// <summary>
        /// Gets the <see cref="IEavValue"/>s attached to the <see cref="IEavAttribute"/>s
        /// of that entity instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IEavValue> GetEavValues();
    }
}
