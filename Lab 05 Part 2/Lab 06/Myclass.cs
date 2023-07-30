using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Myclass
    {
        // Private method to display "Hello World"
        private void sayHello()
        {
            Console.WriteLine("Hello World");
        }

        // Public method to access the private method indirectly
        public void CallSayHello()
        {
            sayHello();
        }

    }
}
