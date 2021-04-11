using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.paginas.paginasDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInserida : ContentPage
    {
        public PaginaInserida()
        {
            InitializeComponent();
        }

        private void AbrirPaginaInicial(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(
                new conteudo01()
                );
        }
    }
}