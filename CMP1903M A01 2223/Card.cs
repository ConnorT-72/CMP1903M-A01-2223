namespace CMP1903M_A01_2223
{
    public class Card
    {
        string face;
        string suit;

        string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades" };
        public Card(string faceValue, string suitVal)
        {
            face = faceValue;
            suit = suitVal;

        }

        public override string ToString()
        {
            return face + "of" + suit;
        }


    }
}
