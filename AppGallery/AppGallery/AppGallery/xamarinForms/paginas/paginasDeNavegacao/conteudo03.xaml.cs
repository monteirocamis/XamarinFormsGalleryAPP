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

        private void VoltarParaInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void InserirPaginaPilha(object sender, EventArgs e)
        {
 /* Navigation.InsertPageBefore(                new conteudo01(),                this                ); */
            Navigation.InsertPageBefore(
            new PaginaInserida(),
            Navigation.NavigationStack[0]  //para dizer em que ordem na pilha a tela vai aparecer
             ); 
        } 
        private void RemoverPaginaPilha(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}