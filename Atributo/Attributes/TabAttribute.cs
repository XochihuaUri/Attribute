using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true )]
    public class TabAttribute : Attribute
    {
        
    }
}
