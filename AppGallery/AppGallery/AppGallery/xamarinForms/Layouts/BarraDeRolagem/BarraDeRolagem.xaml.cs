using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.Layouts.BarraDeRolagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeRolagem : ContentPage
    {
        public BarraDeRolagem()
        {
            InitializeComponent();
        }

        private void RolarPara(object sender, EventArgs e)
        {
            BarraDeScroll.ScrollToAsync(LabelEscolhida, ScrollToPosition.Start, true);
        }
        

        /*BarraDeRolagem.ScrollToAsync(0,100,true)*/
    }
}