using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVValueListToRawValueConverter
    {
        string Convert(IEnumerable<string> values);

        IEnumerable<string> ConvertBack(string input);
    }
}
