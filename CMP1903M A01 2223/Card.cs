using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        public string Suit { get; set; }
        public int Rank { get; set; }

        // Add a property to get the point value of the card
        public int Points
        {
            get
            {
                switch (Rank)
                {
                    case 1: // Ace
                        return 1;
                    case 11: // Jack
                        return 10;
                    case 12: // Queen
                        return 10;
                    case 13: // King
                        return 10;
                    default: // Other cards
                        return Rank;
                }
            }
        }
    }

    public static int SortCards(Card[] cards)
    {
        // Sort by rank
        Array.Sort(cards, (a, b) => a.Rank.CompareTo(b.Rank));

        // Sort within each rank by suit
        for (int i = 0; i < cards.Length - 1; i++)
        {
            if (cards[i].Rank == cards[i + 1].Rank)
            {
                int j = i + 1;
                while (j < cards.Length && cards[j].Rank == cards[i].Rank)
                {
                    j++;
                }
                Array.Sort(cards, i, j - i, (a, b) => a.Suit.CompareTo(b.Suit));
                i = j - 1;
            }
        }

        // Calculate total points earned
        int totalPoints = 0;
        foreach (Card card in cards)
        {
            totalPoints += card.Points;
        }

        // Display total points earned
        Console.WriteLine("You earned {0} points!", totalPoints);

        return totalPoints;
    }

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
}
