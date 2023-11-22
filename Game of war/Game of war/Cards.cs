

namespace GameOfWar
{
    public class Card
    {
        public CardFace Face { get; set; }
        public CardSuit Suite { get; set; }
        public override string ToString()
        {

            int face = (int)Enum.Parse(typeof(CardFace), this.Face.ToString());
            char suite = (char)this.Suite;
            if (face > 10)
            {
                char charFace = this.Face.ToString()[0];
                return $"{charFace}{suite}";
            }
            return $"{face}{suite}";
        }


    }
}

