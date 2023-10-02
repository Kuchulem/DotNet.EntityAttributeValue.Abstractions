namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Interface for converters that convert independent <see cref="IEavValue"/>
    /// or <see cref="IEavValue"/> from an <see cref="IEavEntity"/>.<br/>
    /// 
    /// </summary>
    public interface IEavConverter
    {
        /// <summary>
        /// Converts the <see cref="IEavValue.RawValue"/> of the value
        /// parameter to a typed value in the converted parameter.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        bool TryConvertValue(IEavValue value, out object? converted);

        /// <summary>
        /// Converts all <see cref="IEavValue"/> from an <see cref="IEavEntity"/>
        /// from the entity parameter and fills a <see cref="Dictionary{TKey, TValue}"/>
        /// with the value for each attribute.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        bool TryConvertEntityValues(IEavEntity entity, out Dictionary<IEavAttribute, object?> converted);

        /// <summary>
        /// Conveters the <see cref="IEavValue"/>(s) associated to an
        /// <see cref="IEavAttribute"/> in a specific <see cref="IEavEntity"/>.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="entity"></param>
        /// <param name="converted"></param>
        /// <returns></returns>
        bool TryConvertEntityAttributeValue(IEavAttribute attribute, IEavEntity entity, out object? converted);
    }
}