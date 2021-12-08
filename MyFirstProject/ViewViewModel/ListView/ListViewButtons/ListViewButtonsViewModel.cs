using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.ListView.ListViewButtons
{
    public class ListViewButtonsViewModel : ContentPage
    {
        private List<PlayingCard> _card;
        private ObservableCollection<PlayingCard> _cards;

        public ListViewButtonsViewModel()
        {
            Title = Titles.ListViewButtonsTitle;

            _cards = new ObservableCollection<PlayingCard>();
            _card = PlayingCard.GetCardButton();
            this.LoadCards();
        }

        private void LoadCards()
        {
            try
            {
                _cards.Clear();
                foreach (var c in _card)
                {
                    Cards.Add(c);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public ObservableCollection<PlayingCard> Cards
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
                OnPropertyChanged();
            }
        }

        public Command<PlayingCard> DeleteCommand
        {
            get
            {
                return new Command<PlayingCard>((PlayingCard mov) =>
                {
                    Cards.Remove(mov);
                });
            }
        }
    
    }
}