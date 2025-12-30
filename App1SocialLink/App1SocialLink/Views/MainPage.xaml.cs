using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

//evento navigation para cambiar de pagina
namespace App1SocialLink
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_EntradaConUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EntradaConUsuarioPage));
        }

        private void Button_EntradaSinUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (EntradaSinUsuarioPage));
        }

        private void Button_CrearNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CrearNuevoUsuarioPage));

        }
    }
}
