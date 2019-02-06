using System;

namespace C0731773
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine("Help ! i am stuck in an infinite loop!");
            }


        }

        public static bool peanut()
        {
            return true;
        }
    }
            

}
