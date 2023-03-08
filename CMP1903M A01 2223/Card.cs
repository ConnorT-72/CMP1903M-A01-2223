using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        string face;
        string suit;

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
