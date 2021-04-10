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
    public partial class conteudo03 : ContentPage
    {
        public conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed() //desabilita botao de voltar
        {
            return true;
        }

        private void VoltarParaPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}