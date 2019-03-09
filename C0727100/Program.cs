using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727100
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method2);
                myDelegate();
            }
        }
    }
}
