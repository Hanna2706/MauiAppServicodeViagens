using MauiAppServicodeViagens.Models;

namespace MauiAppServicodeViagens.Views;

public partial class GuiadeViagem : ContentPage
{
	public GuiadeViagem()
	{
		InitializeComponent();

		pck_pacote.ItemsSource = App.Lista_pacotes;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date?.AddMonths(2);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            Viagem h = new Viagem
            {
                PacoteSelecionado = (Pacotes)pck_pacote.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = (DateTime) dtpck_checkin.Date,
                DataCheckOut = (DateTime) dtpck_checkout.Date,
            };

			await Navigation.PushAsync(new ViagemContratada()
            {
                BindingContext = h,
            });

		}catch (Exception ex)
		{
			DisplayAlertAsync("Ops", ex.Message, "OK");
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpck_checkout.MinimumDate = e.NewDate?.AddDays(1);
        dtpck_checkout.MaximumDate = e.NewDate?.AddMonths(2);
    }
}