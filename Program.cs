using System;

namespace uartEx
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int count = 0;
            int bit_number = 0;
            //int iterations = 0;
            string msg = "01000001";

            while (count < 5001)
            {
                if(count == 4999)
                {
                    if(bit_number == 0)
                    {
                        Console.Write('0');
                    }
                    else if(bit_number == 9)
                    {
                        Console.Write("1");
                    }
                    else if((bit_number > 0) && (bit_number < 9))
                    {
                        Console.Write(msg[bit_number - 1]);
                    }
                    else if(bit_number > 9)
                    {
                        Console.Write("1");
                    }
                    bit_number = bit_number + 1;
                    if(bit_number == 20)
                    {
                        bit_number = 0;
                    }
                }
                count = count + 1;
                if(count == 5000)
                {
                    count = 0;
                    //iterations = iterations + 1;
                    //if (iterations == 20)
                    //{
                        //count = 5055;
                    //}
                }
            }
        }
    }
}
