using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     interface ITestInterface1
    {

         void TestMethod1(int a , int b);// we no need to use public and abstract inside the interface.

    }

    interface ITestInterface2 : ITestInterface1 // interface can inherit from another interface.
    {
        void TestMethod2(int a, int b); // we no need to use public and abstract inside the interface.
    }

    class TestClass : ITestInterface2 // class can implement interface.
    {
        // void ITestInterface1.TestMethod1(int a, int b) // we need to use public and override inside the class.
        public void TestMethod1(int a, int b) // we need to use public and override inside the class.
        {
            Console.WriteLine("TestMethod1: " + (a + b));
        }
        public void TestMethod2(int a, int b) // we need to use public and override inside the class.
        {
            Console.WriteLine("TestMethod2: " + (a * b));
        }

    }
        class Program2
        {
            static void Main()
            {
                TestClass testClass = new TestClass();
                testClass.TestMethod2(10, 20); // calling the method of the interface.
                testClass.TestMethod1(10, 20); // calling the method of the interface.


            //another method 
            ITestInterface2 testInterface2 = testClass;
            testInterface2.TestMethod1(10, 20); // calling the method of the interface.
            testInterface2.TestMethod2(10, 20); // calling the method of the interface.

        }
        }
   
}
