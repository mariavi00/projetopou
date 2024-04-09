namespace RafaeMavi;

public partial class GameOverPage : ContentPage

{
    public GameOverPage()
	{
		InitializeComponent();
    }
 private void BotaoDeVoltarClicado (object sender, EventArgs args)	
{
     Application.Current.MainPage = new MainPage();
}
}
