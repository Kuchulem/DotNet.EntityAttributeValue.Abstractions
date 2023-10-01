using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Interface for classes that converts a string value (as stored in DB) to
    /// a usable value and back
    /// </summary>
    /// <typeparam name="T">The expected type for this value</typeparam>
    public interface IEAVValueConverter<T>
    {
        /// <summary>
        /// Converts a string value to a usable value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        T Convert(string value);

        /// <summary>
        /// Converts a usable value to a string storable in DB
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string ConvertBack(T value);
    }
}
