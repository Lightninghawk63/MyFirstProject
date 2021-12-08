using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstProject.Models
{
   
    public class PlayingCard {
        public string Name { get; set; }
        public string Suit { get; set; }
        public string Image { get; set; }
       public int Index { get; set; }

        public PlayingCard(string n, string s, string i)
        {
            Name = n;
            Suit = s;
            Image = i;
        }

        public PlayingCard(string n, string s, int i)
        {
            Name = n;
            Suit = s;
            Index = i;
        }

        public static List<PlayingCard> GetCard()
        {
            return new List<PlayingCard>
            {
                new PlayingCard("Jack", "Clubs", "https://www.aquariusmaximus.com/wp-content/uploads/2016/07/jackclubs.png"),
                new PlayingCard("Queen", "Diamonds", "https://www.aquariusmaximus.com/wp-content/uploads/2016/07/queendiamonds.png"),
                new PlayingCard("King", "Hearts", "https://www.aquariusmaximus.com/wp-content/uploads/2016/07/kinghearts.png")
            };
        }

        public static List<PlayingCard> GetCardButton()
        {
            return new List<PlayingCard>
            {
                new PlayingCard("Jack", "Clubs", 0),
                new PlayingCard("Queen", "Diamonds", 1),
                new PlayingCard("King", "Hearts", 2),
                new PlayingCard("Ace", "Spades", 3)
            };
        }
    }
}
