namespace MaviProjeto;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void BotaoSobreFoiClicado(object sender, EventArgs args)
	{
		frameSobre.IsVisible = true;
	}

	void BotaoFecharFoiClicado(object sender, EventArgs args)
	{
		frameSobre.IsVisible = false;
	}
}

