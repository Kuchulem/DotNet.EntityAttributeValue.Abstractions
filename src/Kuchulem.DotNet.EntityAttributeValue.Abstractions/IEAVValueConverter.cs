using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVValueConverter<T>
    {
        T Convert(string value);

        string ConvertBack(T value);
    }
}
