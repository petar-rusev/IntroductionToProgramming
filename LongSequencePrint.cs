using System;

class LongSequencePrint
{
    static void Main()
    {
        
        Console.SetBufferSize(Console.WindowWidth,1002);
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}, ",i);
            }
            else if (i % 2 > 0)
            {
                Console.WriteLine("-{0}, ",i);
            }
            
        }
        
    }
}

