namespace telaVisu

{
    public partial class telaVisualizacao : ContentPage
    {
        public telaVisualizacao(string nomeUsuario)
        {
            InitializeComponent();
            titulousuario.Text = $"Ficha de {nomeUsuario}";
        }
 
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
 
        private async void OnEditButtonClicked(object sender, EventArgs e)
        {
        
    	bool resposta = await DisplayAlert("Edição de Ficha", "Deseja editar a ficha?", "Sim", "Não");
    
    	if (resposta)
    	{
        await Navigation.PushAsync(new()); // posso direcionar o usuário pra outra pag de edição da ficha
    	}

        }
    }
}