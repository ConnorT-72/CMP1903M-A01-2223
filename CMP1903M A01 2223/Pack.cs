using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public int currentCard = -1;

        //not sure what to do here

        public Pack()
        {
            //Initialise the card pack here
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            currentCard = -1;


        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

        }
        


        public static Card deal()
        {

        }
        
           
            
    

        
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            Console.WriteLine("fuck");
        }
    }



}