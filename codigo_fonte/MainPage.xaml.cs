namespace NomeDoSeuProjeto;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnUserButtonClicked(object sender, EventArgs e)
{
    // Lógica para o botão Usuário
}

private void OnNewRecordButtonClicked(object sender, EventArgs e)
{
    // Lógica para o botão Nova ficha de acolhimento
}

private void OnRegisteredFamiliesButtonClicked(object sender, EventArgs e)
{
    // Lógica para o botão Famílias cadastradas
}

private void OnExitButtonClicked(object sender, EventArgs e)
{
    // Lógica para o botão Sair
    
}

}

