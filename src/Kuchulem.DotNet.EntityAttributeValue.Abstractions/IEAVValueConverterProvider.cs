using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVValueConverterProvider
    {
        IEAVValueConverterProvider Register<T>(EAVValueKind valueKind, IEAVValueConverter<T> converter);

        IEAVValueConverterProvider Register<T>(EAVAttributeBase attribute, IEAVValueConverter<T> converter);

        IEAVValueConverter<T> GetConverter<T>(EAVValueKind valueKind);

        IEAVValueConverter<T> GetConverter<T>(EAVAttributeBase attribute);

        bool TryGetConverter<T>(EAVValueKind valueKind, out IEAVValueConverter<T>? converter);

        bool TryGetConverter<T>(EAVAttributeBase attribute, out IEAVValueConverter<T>? converter);
    }
}
