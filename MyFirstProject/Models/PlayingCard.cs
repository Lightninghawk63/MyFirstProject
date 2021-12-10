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

        public PlayingCard(string n, string s, string i)
        {
            Name = n;
            Suit = s;
            Image = i;
        }

        public PlayingCard(string n, string s)
        {
            Name = n;
            Suit = s;
        }
        public PlayingCard()
        { }

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
                new PlayingCard("Jack", "Clubs"),
                new PlayingCard("Queen", "Diamonds"),
                new PlayingCard("King", "Hearts"),
                new PlayingCard("Ace", "Spades")
            };
        }
    }
}
