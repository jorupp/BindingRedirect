using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace BindingRedirect.Child
{
    public class Class1
    {
        public string GetInfo()
        {
            return typeof(LogManager).AssemblyQualifiedName;
        }
    }
}
