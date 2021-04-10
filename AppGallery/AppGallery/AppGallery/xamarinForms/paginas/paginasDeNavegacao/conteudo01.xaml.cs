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
    public partial class conteudo01 : ContentPage
    {
        public conteudo01()
        {
            InitializeComponent();
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new conteudo02());
        }
    }
}