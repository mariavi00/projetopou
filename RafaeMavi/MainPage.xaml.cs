namespace RafaeMavi;

public partial class MainPage : ContentPage
{
	

	Animais atual;

	Coelho Lola = new Coelho();
		

	Macaco	Jorge = new Macaco();
	

	Vaca	Mimosa = new Vaca();
	public MainPage()
	{
		InitializeComponent();
        
		atual = Lola;
		imgPersonagem.Source=atual.GetArquivo();
	}

	void BotaoSetaFoiClicado(object sender, EventArgs args)
		{
			if(atual==Lola)
			{
			atual=Jorge;
			}
			else if(atual==Jorge)
			{
			atual=Mimosa;
			}
			else if(atual==Mimosa)
			{
			atual=Lola;
			}
			imgPersonagem.Source=atual.GetArquivo();


		}
	
}

