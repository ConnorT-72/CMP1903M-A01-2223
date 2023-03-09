using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        List<Card> pack;

        //Card[] cards = new Card[52];
        //string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K"  };

        
        



        public Pack()
        {
            //Initialise the card pack here
            string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
            Card[] cards = new Card[52];

            
            


        }

        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Random r = new Random();

            







        }



        public static Card deal()
        {
            string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
            Card[] cards = new Card[52];
        }






        public static List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            

        }
            
               
            static public class FisherYates
            {
                static Random r = new Random();
            
                static public void Shuffle(int[] pack)
                {
                    for (int n = pack.Length - 1; n > 0; --n)
                    {
                        int k = r.Next(n + 1);
                        int temp = pack[n];
                        pack[n] = pack[k];
                        pack[k] = temp;
                    }
                }
            }
        
    }



}