namespace RafaeMavi;

public partial class MainPage : ContentPage
{
	macaco Jorge;
	coelho Lola;
	vaca Mimosa;
	public MainPage()
	{
		InitializeComponent();

		Lola = new coelho();
		Lola.SetFome (0.3); 
		Lola.SetSede (0.2);
		Lola.SetAlegria (0.5);

		Jorge = new macaco();
		Jorge.SetFome (0.3);
		Jorge.SetSede (0.2);
		Jorge.SetAlegria (0.5);

		Mimosa = new vaca();
        Mimosa.SetFome (0.3);
		Mimosa.SetSede (0.2);
		Mimosa.SetAlegria (0.5);

	}

	
}

