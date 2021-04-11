using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /* var pagina = new NavigationPage(
                            new xamarinForms.paginas.paginasDeNavegacao.conteudo01()
                        ); */

            /*
             * // criar pagina modal
             * var pagina = new xamarinForms.paginas.modal.conteudo01modal(); 
            
            var pagina = new CarouselPage(); // instancia a pagina
            pagina.Children.Add(new xamarinForms.paginas.paginaCarousel.conteudo01carousel());
            pagina.Children.Add(new xamarinForms.paginas.paginaCarousel.conteudo02carousel());
            pagina.Children.Add(new xamarinForms.paginas.paginaCarousel.conteudo03carousel());

            pagina.CurrentPage = pagina.Children[1]; // carousel com iniciona pagina do meio - conteudo2
*/
            // MainPage = pagina;

            MainPage = new xamarinForms.paginas.paginaCarousel.carousel();

          //  MainPage = new xamarinForms.paginas.modal.conteudo01modal();

         //   MainPage = new xamarinForms.paginas.paginaDeAbas.Abas();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
