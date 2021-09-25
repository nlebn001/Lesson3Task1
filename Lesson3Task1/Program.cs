using System;

namespace Lesson3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int a = 23;
                int b = 14;
                Console.WriteLine($"1st num = {a}, 2nd num= {b}\n");

                int iSum = a + b;
                int iSub = a - b;
                int iMult = a * b;
                int iDiv = a / b;
                int iMod = a % b;

                Console.WriteLine("Int anwers");
                Console.WriteLine($"Sum = {iSum}, Sub = {iSub}, Mult = {iMult}, Div = {iDiv}, Modulo = {iMod}\n");
            }

            {
                float a = 23f;
                float b = 14f; 

                float fSum = (a + b);
                float fSub = (a - b);
                float fMult = (a * b);
                float fDiv = (a / b);
                float fMod = (a % b);
                Console.WriteLine("Float answers");
                Console.WriteLine($"Sum = {fSum}, Sub = {fSub}, Mult = {fMult}, Div = {fDiv}, Modulo = {fMod}");

            }
            
            

        }
    }
}
