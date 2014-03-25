using System;

class FirstTenSequence
{
    static void Main()
    {
        for (int num = 2; num < 12; num++)
        {
            if (num % 2 == 0)
            {
                Console.Write("{0}, ", num);
            }
            else
            {
                Console.Write("-{0}, ",num);
            }
        }
    }
}

