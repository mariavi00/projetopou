namespace RafaeMavi;

public partial class MainPage : ContentPage
{
	

	Animais atual;

	Coelho Lola = new Coelho();
		

	Macaco	Jorge = new Macaco();
	
	IDispatcherTimer timer;

	Vaca	Mimosa = new Vaca();
	public MainPage()
	{
		InitializeComponent();
        
		atual = Lola;

		imgPersonagem.Source=atual.GetArquivo();

		AtualizaPersonagem();
		timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(5);
		timer.Tick+=(s,e)=>PassouTempo();
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
			AtualizaPersonagem();
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
		var estavaMorto=atual.Getmorto();
		Lola.SetFome(Lola.GetFome()-0.1);
		Jorge.SetFome(Jorge.GetFome()-0.1);
		Mimosa.SetFome(Mimosa.GetFome()-0.1);

		Lola.SetSede(Lola.GetSede()-0.1);
		Jorge.SetSede(Jorge.GetSede()-0.1);
		Mimosa.SetSede(Mimosa.GetSede()-0.1);

		Lola.SetAlegria(Lola.GetAlegria()-0.1);
		Jorge.SetAlegria(Jorge.GetAlegria()-0.1);
		Mimosa.SetAlegria(Mimosa.GetAlegria()-0.1);
		AtualizaPersonagem();

		if (estavaMorto != atual.Getmorto())
			imgPersonagem.Source=atual.GetArquivo();
		if (Jorge.Getmorto() &&
		    Lola.Getmorto() &&
		    Mimosa.Getmorto())
		{
		 	Application.Current.MainPage = new GameOverPage();
			timer.Stop();
		}
	}


	
}

