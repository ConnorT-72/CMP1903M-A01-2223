using System;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack myPack = new Pack();
            
            foreach (Card c in myPack.Cards)
                {
                    Console.WriteLine(c);
                }
            Console.WriteLine("How many shuffles do you want?");
            
                
            
        }
    }
}
