using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.paginas.modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class conteudo01modal : ContentPage
    {
        public conteudo01modal()
        {
            InitializeComponent();
        }

        private void abrirModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new paginaModal()); 
        }
    }
}