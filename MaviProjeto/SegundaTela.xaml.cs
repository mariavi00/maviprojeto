namespace MaviProjeto;

public partial class SegundaTela : ContentPage
{
    List<PontodaHistoria> historia = new List<PontodaHistoria>();
  PontodaHistoria PontodaHistoriaAtual;
	
	public SegundaTela()
	{
		InitializeComponent();

	historia.Add(new PontodaHistoria()
	{
		Id = 0,
		Texto = "Qual país tem formato de uma bota?",
		TemResposta=true,
		TextodaResposta01="Itália",
		TextodaResposta02="México",
		TextodaResposta03="Portugal",
		IdLevelResposta01=1,
		IdLevelResposta02=10,
		IdLevelResposta03=10,
	});

    historia.Add(new PontodaHistoria()
	{
		Id = 1,
		Texto = "Qual o menor país do mundo?",
		TemResposta=true,
		TextodaResposta01="Brasil",
		TextodaResposta02="Espanha",
		TextodaResposta03="Vaticano",
		IdLevelResposta01=10,
		IdLevelResposta02=10,
		IdLevelResposta03=2,
	});

	historia.Add(new PontodaHistoria()
	{
		Id = 2,
		Texto = "Qual o maior país do mundo?",
		TemResposta=true,
		TextodaResposta01="Russia",
		TextodaResposta02="Estados Unidos",
		TextodaResposta03="Canadá",
		IdLevelResposta01=3,
		IdLevelResposta02=10,
		IdLevelResposta03=10,
	});

	historia.Add(new PontodaHistoria()
	{
		Id = 3,
		Texto = "A que temperatura a água ferve?",
		TemResposta=true,
		TextodaResposta01="180º",
		TextodaResposta02="100º",
		TextodaResposta03="200º",
		IdLevelResposta01=10,
		IdLevelResposta02=4,
		IdLevelResposta03=10,
	});

	historia.Add(new PontodaHistoria()
	{
		Id = 4,
		Texto = "Qual o maior planeta do sistema solar?",
		TemResposta=true,
		TextodaResposta01="Marte",
		TextodaResposta02="Terra",
		TextodaResposta03="Júpiter",
		IdLevelResposta01=10,
		IdLevelResposta02=10,
		IdLevelResposta03=5,
	});

	historia.Add(new PontodaHistoria()
	{
		Id = 5,
		Texto = "Parabéns!! Você acertou todas respostas.",
		TemResposta=false,
		Ganhou=true
	});

	historia.Add(new PontodaHistoria()
	{
		Id = 10,
		Texto = "Você errou!",
		TemResposta=false,
		GameOver=true
	});

	Iniciar();
	}

	void Iniciar()
	{
		TrocaPontodaHistoriaAtual(0);
	}

	void PreencherPagina()
	{
		labelTexto.Text = PontodaHistoriaAtual.Texto;

		if (PontodaHistoriaAtual.GameOver)
			frameGameOver.IsVisible = true;
		else
			frameGameOver.IsVisible = false;

		if (PontodaHistoriaAtual.Ganhou)
			frameGanhou.IsVisible = true;
		else
			frameGanhou.IsVisible = false;

		 (PontodaHistoriaAtual.TemResposta)

		BotaoResposta01.Text = PontodaHistoriaAtual.TextoDaResposta01;
      	BotaoResposta02.Text = PontodaHistoriaAtual.TextoDaResposta02;
      	BotaoResposta03.Text = PontodaHistoriaAtual.TextoDaResposta03;

	}

	void TrocaPontodaHistoriaAtual(int id)
  {
    PontodaHistoriaAtual = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }

  void Botao01FoiClicado(object sender, EventArgs args)
  {
    TrocaPontodaHistoriaAtual(PontodaHistoriaAtual.IdLevelResposta01);
  }

  void Botao02FoiClicado(object sender, EventArgs args)
  {
    TrocaPontodaHistoriaAtual(PontodaHistoriaAtual.IdLevelResposta02);
  }

   void Botao03FoiClicado(object sender, EventArgs args)
  {
    TrocaPontodaHistoriaAtual(PontodaHistoriaAtual.IdLevelResposta03);
  }

  void BotaoDeVoltarClicado(object sender, EventArgs args)
  {
    Iniciar();
  }


}