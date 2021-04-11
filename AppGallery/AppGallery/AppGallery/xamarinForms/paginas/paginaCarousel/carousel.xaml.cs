using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.paginas.paginaCarousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carousel : CarouselPage
    {
        public carousel()
        {
            InitializeComponent();  // começa a carregar o xaml

            CurrentPage = Children[1];  //comeca pelo indice de posicao 2 , que é a pagina2carousel
        }
    }
}