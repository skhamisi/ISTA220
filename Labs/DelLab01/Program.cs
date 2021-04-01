using System;

namespace DelLab01
{
    //1. declare a delegate type
    delegate void MyDel();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Del20200329a");
            //2. instantiate a delegate object
            //either of the two lines below, a or b
            //var methodDelegate = new MyDel(SomeMethod); //a
            MyDel methodDelegate = SomeMethod; //b
            //3. call the delegate
            methodDelegate();
        }

        static void SomeMethod()
        {
            Console.WriteLine("This is the body of the method named 'someMethod()'");
        }
    }
}
