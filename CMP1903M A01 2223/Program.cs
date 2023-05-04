using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] cards = new Card[]
            {
                new Card { Suit = "Hearts", Rank = 2 },
                new Card { Suit = "Diamonds", Rank = 7 },
                new Card { Suit = "Clubs", Rank = 11 },
                new Card { Suit = "Spades", Rank = 1 },
                new Card { Suit = "Hearts", Rank = 12 },
                new Card { Suit = "Diamonds", Rank = 2 },
                new Card { Suit = "Clubs", Rank = 1 },
                new Card { Suit = "Spades", Rank = 13 }
            };

            int totalPoints = SortCards(cards);

            Console.WriteLine("Total points earned: {0}", totalPoints);

            
            Console.WriteLine("Deal another card? (y/n)");
            string answer = Console.ReadLine();

            while (answer.ToLower() == "y")
            {
                Console.WriteLine("Enter the suit and rank of the card (e.g. Hearts 3):");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                if (parts.Length == 2)
                {
                    string suit = parts[0];
                    int rank;
                    if (int.TryParse(parts[1], out rank))
                    {
                        Card card = new Card { Suit = suit, Rank = rank };
                        Card[] newCards = cards.Concat(new Card[] { card }).ToArray();
                        totalPoints = SortCards(newCards);
                        Console.WriteLine("Total points earned: {0}", totalPoints);
                    }
                    else
                    {
                        Console.WriteLine("Invalid rank entered.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input entered.");
                }

                
                Console.WriteLine("Deal another card? (y/n)");
                answer = Console.ReadLine();
            }
        }
    }
}
