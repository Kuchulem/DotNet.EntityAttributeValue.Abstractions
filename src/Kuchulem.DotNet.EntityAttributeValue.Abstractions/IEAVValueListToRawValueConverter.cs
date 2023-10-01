using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Converts a string raw value (as stored in DB) to a list of strings and
    /// back
    /// </summary>
    public interface IEAVValueListToRawValueConverter
    {
        /// <summary>
        /// Converts a list of strings to a string raw value
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string Convert(IEnumerable<string> values);

        /// <summary>
        /// Converts back a string raw value to a list of strings
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        IEnumerable<string> ConvertBack(string input);
    }
}
