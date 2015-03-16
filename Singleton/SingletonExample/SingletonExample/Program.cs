using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    /// <summary>
    /// Example usage of the singleton.
    /// Created By: Edward Eisenhart
    /// Created On: Mar-15-2015
    /// Contact: EdwardEisenhart@EdwardEisenhart.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Trying to new up an instance causes a compiler error
            //MySingleton compilerError = new MySingleton();


            MySingleton s = MySingleton.Instance; // retrieve the only instance using static property (global scope)
            MySingleton s2 = MySingleton.Instance; // This will grab the exact same instance as 's'
            s.ExampleMethod(); // Now we can use the instance
        }
    }
}
