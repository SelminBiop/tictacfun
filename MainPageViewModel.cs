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

    public enum TourDuJoueur 
    {
        PremierJoueur,
        DeuxiemeJoueur
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

        [ObservableProperty]
        ICommand _quatriemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _quatriemeCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _troisiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _troisiemeCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _deuxiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _deuxiemeCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _sixiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _sixiemeCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _septiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _septiemeCaseValeur = ValeursPossible.Vide;

        [ObservableProperty]
        ICommand _huitiemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _huitiemeCaseValeur = ValeursPossible.Vide;


        [ObservableProperty]
        ICommand _neuviemeCaseTouchee;

        [ObservableProperty]
        ValeursPossible _neuviemeCaseValeur = ValeursPossible.Vide;

        private TourDuJoueur _joueurCourant = TourDuJoueur.PremierJoueur;
        public MainPageViewModel()
        {
            _premiereCaseTouchee = new Command(SurPremiereCaseTouchee);
            _deuxiemeCaseTouchee = new Command(SurDeuxiemeCaseTouchee);
            _troisiemeCaseTouchee = new Command(SurTroisiemeCaseTouchee);
            _quatriemeCaseTouchee = new Command(SurQuatriemeCaseTouchee);
            _cinquiemeCaseTouchee = new Command(SurCinquiemeCaseTouchee);
            _sixiemeCaseTouchee = new Command(SurSixiemeCaseTouchee);
            _septiemeCaseTouchee = new Command(SurSeptiemeCaseTouchee);
            _huitiemeCaseTouchee = new Command(SurHuitiemeCaseTouchee);
            _neuviemeCaseTouchee = new Command(SurNeuviemeCaseTouchee);
        }        
        private void SurPremiereCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => PremiereCaseValeur = nouvelleValeur, valeurDeLaCase: PremiereCaseValeur);
        }
        private void SurCinquiemeCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => CinquiemeCaseValeur = nouvelleValeur, valeurDeLaCase: CinquiemeCaseValeur);
        }
              
        private void SurDeuxiemeCaseTouchee(object obj)
        {     
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => DeuxiemeCaseValeur = nouvelleValeur, valeurDeLaCase: DeuxiemeCaseValeur);
        }
        private void SurTroisiemeCaseTouchee(object obj) 
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => TroisiemeCaseValeur = nouvelleValeur, valeurDeLaCase: TroisiemeCaseValeur);
        }
        private void SurQuatriemeCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => QuatriemeCaseValeur = nouvelleValeur, valeurDeLaCase: QuatriemeCaseValeur);
        }
        private void SurSixiemeCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => SixiemeCaseValeur = nouvelleValeur, valeurDeLaCase: SixiemeCaseValeur);
        }
        private void SurSeptiemeCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => SeptiemeCaseValeur = nouvelleValeur, valeurDeLaCase: SeptiemeCaseValeur);
        }
        private void SurHuitiemeCaseTouchee(object obj)
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => HuitiemeCaseValeur = nouvelleValeur, valeurDeLaCase: HuitiemeCaseValeur);
        }
        private void SurNeuviemeCaseTouchee(object obj) 
        {
            SurCaseTouchee(valeurDeLaCaseToucheeModification: nouvelleValeur => NeuviemeCaseValeur = nouvelleValeur, valeurDeLaCase: NeuviemeCaseValeur);
        }

        private void SurCaseTouchee(Action<ValeursPossible> valeurDeLaCaseToucheeModification, ValeursPossible valeurDeLaCase) 
        {
            if (valeurDeLaCase is not ValeursPossible.Vide) 
            {
                return;
            }

            if (_joueurCourant is TourDuJoueur.PremierJoueur) 
            {
                valeurDeLaCaseToucheeModification(ValeursPossible.X);
                _joueurCourant = TourDuJoueur.DeuxiemeJoueur;
            } 
            else 
            {
                valeurDeLaCaseToucheeModification(ValeursPossible.O);
                _joueurCourant = TourDuJoueur.PremierJoueur;
            }
        }
    }
}