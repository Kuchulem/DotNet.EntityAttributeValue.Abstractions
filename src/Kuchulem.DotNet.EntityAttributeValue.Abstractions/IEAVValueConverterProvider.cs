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
    public interface IEAVValueConverterProvider
    {
        /// <summary>
        /// Registers a converter for a <see cref="EAVValueKind"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        IEAVValueConverterProvider Register<T>(EAVValueKind valueKind, IEAVValueConverter<T> converter);

        /// <summary>
        /// Registers a converter for an <see cref="IEAVAttribute"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        IEAVValueConverterProvider Register<T>(IEAVAttribute attribute, IEAVValueConverter<T> converter);

        /// <summary>
        /// Gets a converter for a <see cref="EAVValueKind"/> that was 
        /// previously registered.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <returns></returns>
        IEAVValueConverter<T> GetConverter<T>(EAVValueKind valueKind);

        /// <summary>
        /// Gets a converter for a <see cref="IEAVAttribute"/> that was 
        /// previously registered.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <returns></returns>
        IEAVValueConverter<T> GetConverter<T>(IEAVAttribute attribute);

        /// <summary>
        /// Tries to get a converter for a <see cref="EAVValueKind"/>and store 
        /// it in the <em>converter</em> parameter.<br/>
        /// Returns <em>True</em> if a converter was found, <em>false</em>
        /// otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        bool TryGetConverter<T>(EAVValueKind valueKind, out IEAVValueConverter<T>? converter);

        /// <summary>
        /// Tries to get a converter for a <see cref="IEAVAttribute"/>and store
        /// it in the <em>converter</em> parameter.<br/>
        /// Returns <em>True</em> if a converter was found, <em>false</em>
        /// otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        bool TryGetConverter<T>(IEAVAttribute attribute, out IEAVValueConverter<T>? converter);
    }
}
