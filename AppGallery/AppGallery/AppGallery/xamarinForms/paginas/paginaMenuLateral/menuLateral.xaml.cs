using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.paginas.paginaMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class menuLateral : MasterDetailPage
    {
        public menuLateral()
        {
            InitializeComponent();
        }

        private void abrirPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new conteudo1menu());
            IsPresented = false;
        }

        private void abrirPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new conteudo2menu());
            IsPresented = false;
        }

        private void abrirPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new conteudo3menu());
            IsPresented = false;
        }

        
    }
}