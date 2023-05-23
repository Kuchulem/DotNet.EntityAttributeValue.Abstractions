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

        IEAVValueConverterProvider Register<T>(IEAVAttribute attribute, IEAVValueConverter<T> converter);

        IEAVValueConverter<T> GetConverter<T>(EAVValueKind valueKind);

        IEAVValueConverter<T> GetConverter<T>(IEAVAttribute attribute);

        bool TryGetConverter<T>(EAVValueKind valueKind, out IEAVValueConverter<T>? converter);

        bool TryGetConverter<T>(IEAVAttribute attribute, out IEAVValueConverter<T>? converter);
    }
}
