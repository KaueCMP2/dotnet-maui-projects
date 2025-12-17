namespace MobileApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                DisplayAlert("Alerta", "Preencha todos os campos", "OK");
            }
        }
    }
}
