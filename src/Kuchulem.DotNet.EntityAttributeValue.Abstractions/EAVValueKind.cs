using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public enum EAVValueKind
    {
        None = 0,
        Integer = 1,
        Boolean = 2,
        String = 3,
        Entity = 5,
        DateTime = 6,
        Number = 7,
    }
}
