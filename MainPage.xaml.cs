namespace tictactroll;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel mainPageViewModel)
	{
		BindingContext = mainPageViewModel;
		InitializeComponent();
	}
}

