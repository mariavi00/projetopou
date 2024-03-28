using SystemConfiguration;

namespace RafaeMavi;

public partial class MainPage : ContentPage
{
	int count = 0;
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
		Mimosa = new vaca();


	}

	
}

