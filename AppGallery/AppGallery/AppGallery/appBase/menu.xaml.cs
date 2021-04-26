using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.appBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menu : MasterDetailPage
    {
        public menu()
        {
            InitializeComponent();
        }

        private void abrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.paginasDeConteudo.conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

                }

        private void abrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.paginasDeNavegacao.conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void abrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.paginaCarousel.carousel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void abrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.paginaAbas.abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void abrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.paginaMenuLateral.menuLateral();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;

        }

        private void abrirModal(object sender, EventArgs e)
        {

            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.paginas.modal.conteudo01modal();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.PilhasLayout.Pilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.GradeLayout.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.AbsoluteLayout.Absoluto();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativoLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.RelativoLayout.Relativo();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexivo(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.FlexivoLayout.Flexivo();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirBarraRolagem(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.BarraDeRolagem.BarraDeRolagem();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFrame(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.QuadradoLayout.Quadrado();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirControle(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.ControleLayout.Controle();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        
      

        private void AbrirCardDiretor(object sender, EventArgs e)
        {
          //  ((MasterDetailPage)App.Current.MainPage).Detail = new xamarinForms.Layouts.ControleLayout.CardDiretor();
           ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}