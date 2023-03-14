namespace CMP1903M_A01_2223
{
    public class Card
    {
        string face;
        string suit;

        string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
        Card[] cards = new Card[52];
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
