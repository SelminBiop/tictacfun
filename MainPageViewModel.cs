using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace tictactroll
{
	public enum ValeursPossible
	{
		Vide,
		X,
		O
	}

    public sealed partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ICommand _premiereCaseTouchee;

        [ObservableProperty]
        ValeursPossible _premiereCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _cinquiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _cinquiemeCaseValeur = ValeursPossible.Vide;

        public MainPageViewModel()
        {
            _premiereCaseTouchee = new Command(SurPremiereCaseTouchee);
            _cinquiemeCaseTouchee = new Command(SurCinquiemeCaseTouchee);
        }
        
        
        private void SurPremiereCaseTouchee(object obj)
        {
			if (PremiereCaseValeur is ValeursPossible.Vide)
			{
                PremiereCaseValeur = ValeursPossible.X;
				return;
            }
            if (PremiereCaseValeur is ValeursPossible.X)
            {
                PremiereCaseValeur = ValeursPossible.O;
				return;
            }
            if (PremiereCaseValeur is ValeursPossible.O)
            {
                PremiereCaseValeur = ValeursPossible.Vide;
				return;
            }
        }

        private void SurCinquiemeCaseTouchee(object obj)
        {
            if (CinquiemeCaseValeur is ValeursPossible.Vide)
            {
                CinquiemeCaseValeur = ValeursPossible.X;
                return;
            }
            if (CinquiemeCaseValeur is ValeursPossible.X)
            {
                CinquiemeCaseValeur = ValeursPossible.O;
                return;
            }
            if (CinquiemeCaseValeur is ValeursPossible.O)
            {
                CinquiemeCaseValeur = ValeursPossible.Vide;
                return;
            }
        }
    }
}

