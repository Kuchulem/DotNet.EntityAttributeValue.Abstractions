using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Interface for converter provider.<br/>
    /// Provides methods to register and retrieve converters
    /// </summary>
    public interface IEavRawValueConverterProvider
    {

        /// <summary>
        /// Gets the converter matching the <see cref="IEavAttribute"/>
        /// </summary>
        /// <param name="attribute">The attribute for witch the converter should be found</param>
        /// <returns>The converter</returns>
        public IEavRawValueConverter GetConverter(IEavAttribute attribute);

        /// <summary>
        /// Registers a converter for attributes matching the predicate.
        /// </summary>
        /// <param name="predicate">Function that returns true when an attribute matches the expected pattern</param>
        /// <param name="converter"></param>
        /// <returns>The provider itself for chaining</returns>
        public IEavRawValueConverterProvider Register(Func<IEavAttribute, bool> predicate, IEavRawValueConverter converter);

        /// <summary>
        /// Sets the converter for the <see cref="IEavAttribute"/> to the referenced parameter
        /// <em>converted</em>. Returns false if no converter where found.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns>Wether the converter was found or not</returns>
        public bool TryGetConverter(IEavAttribute attribute, out IEavRawValueConverter? converter);
    }
}
