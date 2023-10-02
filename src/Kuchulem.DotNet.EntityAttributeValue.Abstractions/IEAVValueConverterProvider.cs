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
    public interface IEavValueConverterProvider
    {
        /// <summary>
        /// Registers a converter for a <see cref="EavValueKind"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        IEavValueConverterProvider Register<T>(EavValueKind valueKind, IEavValueConverter<T> converter);

        /// <summary>
        /// Registers a converter for an <see cref="IEavAttribute"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        IEavValueConverterProvider Register<T>(IEavAttribute attribute, IEavValueConverter<T> converter);

        /// <summary>
        /// Gets a converter for a <see cref="EavValueKind"/> that was 
        /// previously registered.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <returns></returns>
        IEavValueConverter<T> GetConverter<T>(EavValueKind valueKind);

        /// <summary>
        /// Gets a converter for a <see cref="IEavAttribute"/> that was 
        /// previously registered.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <returns></returns>
        IEavValueConverter<T> GetConverter<T>(IEavAttribute attribute);

        /// <summary>
        /// Tries to get a converter for a <see cref="EavValueKind"/>and store 
        /// it in the <em>converter</em> parameter.<br/>
        /// Returns <em>True</em> if a converter was found, <em>false</em>
        /// otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueKind"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        bool TryGetConverter<T>(EavValueKind valueKind, out IEavValueConverter<T>? converter);

        /// <summary>
        /// Tries to get a converter for a <see cref="IEavAttribute"/>and store
        /// it in the <em>converter</em> parameter.<br/>
        /// Returns <em>True</em> if a converter was found, <em>false</em>
        /// otherwise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        bool TryGetConverter<T>(IEavAttribute attribute, out IEavValueConverter<T>? converter);
    }
}
