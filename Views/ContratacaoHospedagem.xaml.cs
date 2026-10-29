namespace AppHotel2.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		// carrega a lista de quartos no Picker
		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		// check-in: de hoje até daqui 1 mês
		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

		// check-out: no mínimo 1 dia depois do check-in
		dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
		dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = (DateTime)elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
	}

	private async void Button_Avancar_Clicked(object sender, EventArgs e)
	{
		try
		{
			await Navigation.PushAsync(new HospedagemContratada());
		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
	}

	private async void Button_Sobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}
