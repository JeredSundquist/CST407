using System;

namespace _CST407____Test2_Program
{
    //REMAINDER MATH WRITTEN IN C#
    //AUTHOR: Jered Sundquist
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTS
            const int BAS = 50011;//<---base number
            const int EXP = 2479891;//<---exponent: used as number of loops for remainder math operation
            const int MOD = 302108907;//<---modulus

            //local variables
            int ndx = 1;
            int remainder = 0;//<---remainder: used to store result of operation

            //initial setup
            remainder = 1 * BAS % MOD;

            //output initial setup
            Console.WriteLine("Loop[" + ndx + "]--->" + " Result = " + remainder);
            ndx++;

            //remainder math operation loop
            while (ndx <= EXP)
            {
                //operation
                remainder = remainder * BAS % MOD;

                //output to console
                Console.WriteLine("Loop[" + ndx +"]--->" + " Result = " + remainder);

                //increment index
                ndx++;
            }

            //console output final result
            Console.WriteLine("Answer = " + remainder);

            //keep console open
            Console.Read();
        }
    }
}
