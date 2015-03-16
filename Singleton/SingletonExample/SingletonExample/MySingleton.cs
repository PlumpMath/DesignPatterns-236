using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{

    /// <summary>
    /// Example of a singleton.
    /// Created By: Edward Eisenhart
    /// Created On: Mar-15-2015
    /// Contact: EdwardEisenhart@EdwardEisenhart.com
    /// </summary>
    public sealed class MySingleton
    {
        private static MySingleton instance;

        /// <summary>
        /// Retreives the instance of <see cref="MySingleton"/>
        /// </summary>
        public static MySingleton Instance 
        {
            get 
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }

                return instance;
            } 
        }

        /// <summary>
        /// Since there is a private constructor, no public default constructor is created
        /// and there is no way to constuct an instance of the singleton from another class.
        /// This ensures only 1 instance of the singleton exists.
        /// </summary>
        private MySingleton() { }

        /// <summary>
        /// Example instance method of the singleton
        /// </summary>
        public void ExampleMethod()
        {

        }

    }
}
