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
    public partial class paginaModal : ContentPage
    {
        public paginaModal()
        {
            InitializeComponent();
        }

        private void fecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}