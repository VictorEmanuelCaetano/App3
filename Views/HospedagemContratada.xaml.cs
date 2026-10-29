namespace AppHotel2.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private async void Button_Voltar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
