using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Abstract class to be extended by EAV Attributes models.
    /// 
    /// An attribute is the configuration of a property stored in database.
    /// It defines :
    /// <list type="bullet">
    ///     <item><see cref="AttributeName"/> witch should be unique and describe the attribute. ie : <em>"BookDescription"</em>. It is comparable to a property name</item>
    ///     <item><see cref="ValueKind"/> witch describes the type of data stored. See <see cref="EAVValueKind"/> for more information.</item>
    ///     <item><see cref="ValueListKind"/> witch defines if the data is selected from a list. See <see cref="EAVValueListKind"/> for more information.</item>
    /// </list>
    /// <code>
    ///  _______________              __________________
    /// | EAVEntityBase |            | EAVAttributeBase |
    /// |_______________|            |__________________|
    /// |               |            | + AttributeName  |
    /// |               |            | + ValueKind      |
    /// |               |            | + ValueListKind  |
    /// |_______________|            |__________________|
    ///         ^                              ^
    ///        /_\                            /_\
    ///         |                              |
    ///         |                              |
    ///         |                              |
    ///  _______|_______              _________|________
    /// |      Book     |            |  BookAttribute   |
    /// |_______________|            |__________________|
    /// | + Id          |            | + Id             |
    /// | + Title       |            |                  |
    /// |_______________|            |__________________|
    /// </code>
    /// </summary>
    public abstract class EAVAttributeBase
    {
        /// <summary>
        /// The name of the attribute, should be considered as a property name and should be unique for an entity.
        /// </summary>
        public virtual string? AttributeName { get; set; }

        /// <summary>
        /// The type of value the <see cref="EAVValueBase"/> for this attribute should store. See <see cref="EAVValueKind"/> for more information.
        /// </summary>
        public EAVValueKind ValueKind { get; set; }

        /// <summary>
        /// Defines the type of list used to hold the values. See <see cref="EAVValueListKind"/> for more information.
        /// </summary>
        public EAVValueListKind ValueListKind { get; set; }
    }
}
