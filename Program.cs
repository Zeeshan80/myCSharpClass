using System;

namespace myCSharpClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kapitell 3 - Methods  

            int num1 = 5;

            int num2 = 0;

            int result;

           // result = num1 / num2;

            try {

                int x = 10;
                int y = 10;
                Console.WriteLine(x / 0);
            
            }
            catch (Exception) {  
            
                Console.WriteLine("Det går ikke ann å dele på null, sov du i matte timen..??");
            }

  

        }
    }
}
