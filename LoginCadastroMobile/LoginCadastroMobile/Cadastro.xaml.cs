namespace LoginCadastroMobile;

public partial class Cadastro : ContentPage
{
    public Cadastro()
    {
        InitializeComponent();
    }

    private void btnCadastro_Clicked(object sender, EventArgs e)
    {
    }

    private void btnVoltarLogin_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}