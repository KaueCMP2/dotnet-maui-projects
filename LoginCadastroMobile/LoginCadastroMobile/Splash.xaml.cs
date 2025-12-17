using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace LoginCadastroMobile;

public partial class Splash : ContentPage
{
	public Splash()
	{
		InitializeComponent();
	}

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        await Task.Delay(5000);
        App.Current.MainPage = new MainPage();
    }
}