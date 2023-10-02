using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Factory for the <see cref="IEavRawValueConverterProvider"/> implementations.<br/>
    /// Converters can be registered for a <see cref="EavValueKind"/> or
    /// an <see cref="IEavAttribute"/> validator.
    /// </summary>
    public interface IEavRawValueConverterProvider
    {
        /// <summary>
        /// Registers a <see cref="IEavRawValueConverter"/> for any
        /// attribute that matches the validator (returns <em>true</em>).
        /// </summary>
        /// <param name="validator"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        IEavRawValueConverterProvider Register(Func<IEavAttribute, bool> validator, IEavRawValueConverter converter);

        /// <summary>
        /// Gets a <see cref="IEavRawValueConverter"/> for the attribute,
        /// using registered validators. If none found, SHOULD throw an exception.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        IEavRawValueConverter GetConverter(IEavAttribute attribute);

        /// <summary>
        /// Try get a <see cref="IEavRawValueConverter"/> for the
        /// <see cref="IEavAttribute"/> matching a registered validator.
        /// If non found, returns false.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        bool TryGetConverter(IEavAttribute attribute, out IEavRawValueConverter? converter);
    }
}
