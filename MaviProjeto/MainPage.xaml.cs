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

	void BotaoIniciarFoiClicado(object sender, EventArgs args)
	{
		Application.Current.MainPage = new SegundaTela();
	}
}

