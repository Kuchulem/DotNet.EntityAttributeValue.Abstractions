using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Interface to be implemented to create a converter for a
    /// <see cref="IEavValue.RawValue"/>.<br/>
    /// The converter will implement a method to convert the raw value
    /// to an expected type (<see cref="IEavRawValueConverter.Convert(string)"/>
    /// and its pendant method to convert from a typed value to the
    /// raw value (<see cref="IEavRawValueConverter.ConvertBack(object)"/>)
    /// </summary>
    public interface IEavRawValueConverter
    {
        /// <summary>
        /// COnverts a raw value from <see cref="IEavValue.RawValue"/>
        /// to a value of the typeparam of the implementation.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The converted and casted value.</returns>
        object Convert(string value);

        /// <summary>
        /// Converts a value to a raw value for
        /// <see cref="IEavValue.RawValue"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string ConvertBack(object value);
    }
}
