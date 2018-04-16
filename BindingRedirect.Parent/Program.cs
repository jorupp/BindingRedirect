using BindingRedirect.Child;
using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingRedirect.Parent
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Parent: {GetTypeFromParent()}");
                Console.WriteLine($"Child: {GetTypeFromChild()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        private static string GetTypeFromParent()
        {
            return typeof(LogManager).AssemblyQualifiedName;
        }

        private static string GetTypeFromChild()
        {
            return new Class1().GetInfo();
        }
    }
}
