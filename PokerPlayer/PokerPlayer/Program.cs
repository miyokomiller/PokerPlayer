using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    class PokerPlayer
    {
        // Enum of different hand types
        public enum HandType
        {
            HighCard = 0,
            OnePair,
            TwoPair,
            ThreeOfaKind,
            Straight,
            FLush,
            FullHouse,
            FourOfaKind,
            StraightFlush,
            RoyalFlush,


        }
        // Rank of hand that player holds
        public HandType HandRank
        {
            get;
        }
        // Constructor that isn't used
        public PokerPlayer() { }
        public bool HasPair()
        {
            return false;
        }
        public bool HasTwoPair()
        {
            return false;
        }
        public bool HasThreeOfAKind()
        {
            return false;
        }
        public bool HasStraight()
        {
            return false;
        }
        public bool HasFlush()
        {
            return false;
        }
        public bool HasFullHouse()
        {
            return false;
        }
        public bool HasFourOfAKind()
        {
            return false;
        }
        public bool HasStraightFlush()
        {
            return false;
        }
        public bool HasRoyalFlush()
        {
            return false;
        }
    }
    //Guides to pasting your Deck and Card class

    //  *****Deck Class Start*****
    

    //  *****Deck Class End*******

    //  *****Card Class Start*****   
    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public enum Suit
    {
        Spades = 1,
        Clubs,
        Diamonds,
        Hearts
    }
    class Card
    {
        private string _rank;
        public Rank Rank { get; set; }
        private string _suit;
        public Suit Suit { get; set; }

        public Card(int rank, int suit)
        {
            this.Rank = (Rank)rank;
            this.Suit = (Suit)suit;
        }
    }

    //  *****Card Class End*******
}
