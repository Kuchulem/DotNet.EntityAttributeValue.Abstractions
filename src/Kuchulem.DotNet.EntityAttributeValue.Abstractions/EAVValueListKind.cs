using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    /// <summary>
    /// Defines if the value is selected from a list and if
    /// it is a single or multiple selection
    /// </summary>
    public enum EavValueListKind
    {
        /// <summary>
        /// No list
        /// </summary>
        None = 0,
        /// <summary>
        /// List with single element selection (ie : radio or dropdown)
        /// </summary>
        Single = 1,
        /// <summary>
        /// List with multiple element selection (ie : checkboxes or multiselect)
        /// </summary>
        Multiple = 2,
    }
}
