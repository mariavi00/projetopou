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
		AtualizaPersonagem();
		var timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(5);
		timer.Tick+=(s,e)=>
		PassouTempo();
		timer.Start();
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

	void AtualizaPersonagem()
	{
		progressoFome.Progress=atual.GetFome();
		progressoSede.Progress=atual.GetSede();
		progressoAlegria.Progress=atual.GetAlegria();
	}

	void BotaoComidaFoiClicado(object sender, EventArgs args)	
	   {
		 atual.SetFome(atual.GetFome()+0.1);
		 AtualizaPersonagem();
	   }

	void BotaoAguaFoiClicado(object sender, EventArgs args)	
	   {
		 atual.SetSede(atual.GetSede()+0.1);
		 AtualizaPersonagem();
	   }

	void BotaoBrinquedoFoiClicado(object sender, EventArgs args)	
	   {
		 atual.SetAlegria(atual.GetAlegria()+0.1);
		 AtualizaPersonagem();
	   }

	void PassouTempo()
	{
		atual.SetFome(atual.GetFome()-0.1);
		atual.SetSede(atual.GetSede()-0.1);
		atual.SetAlegria(atual.GetAlegria()-0.1);
		AtualizaPersonagem();
	}


	
}

