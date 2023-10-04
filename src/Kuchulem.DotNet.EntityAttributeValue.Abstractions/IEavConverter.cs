using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Service interface to convert <see cref="IEavValue"/> to a typed and usable value
    /// by the application.
    /// </summary>
    public interface IEavConverter
    {
        /// <summary>
        /// Converts the raw value from <see cref="IEavValue.RawValue"/> to
        /// the referenced parameter <em>converted</em>.
        /// Returns true if conversion was done, false if no converter
        /// was found and throws an exception if no attribute is provided
        /// by the <see cref="IEavValue.GetEavAttribute"/> method.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        public bool TryConvertValue(IEavValue value, out object? converted);

        /// <summary>
        /// Tries to convert the values of an entity attributes.<br/>
        /// When multiple <see cref="IEavValue"/> are found for a single
        /// <see cref="IEavAttribute"/> only the first one is used as value
        /// unless the <see cref="IEavAttribute.ValueListKind"/> property
        /// is <see cref="EavValueListKind.Multiple"/>. In that case the
        /// conversion result is an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="entity"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        public bool TryConvertEntityAttributeValue(IEavAttribute attribute, IEavEntity entity, out object? converted);

        /// <summary>
        /// Converts all <see cref="IEavValue"/> for all <see cref="IEavAttribute"/> of
        /// an entity and populates a <see cref="Dictionary{TKey, TValue}"/> with
        /// the attribute as key and the convertion result as value.<br/>
        /// When multiple <see cref="IEavValue"/> are found for a single
        /// <see cref="IEavAttribute"/> only the first one is used as value
        /// unless the <see cref="IEavAttribute.ValueListKind"/> property
        /// is <see cref="EavValueListKind.Multiple"/>. In that case the
        /// convertion result is an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        public bool TryConvertEntityValues(IEavEntity entity, out Dictionary<IEavAttribute, object?> converted);
    }
}
