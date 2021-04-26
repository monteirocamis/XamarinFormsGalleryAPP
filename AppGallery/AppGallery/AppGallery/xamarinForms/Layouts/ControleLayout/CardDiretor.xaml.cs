using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.xamarinForms.Layouts.ControleLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDiretor : ContentView
    {
        public static readonly BlindableProperty NomeProperty = BlindableProperty.Create("Nome", typeof(string),typeof(CardDiretor));
        public static readonly BlindableProperty DescricaoProperty = BlindableProperty.Create("Descricao", typeof(string),typeof(CardDiretor));
        public static readonly BlindableProperty BoxViewColorProperty = BlindableProperty.Create("BoxViewColor", typeof(Color),typeof(CardDiretor));


        /* public string Nome {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public string Descricao {
            get { return (string)GetValue(DescricaoProperty); }
            set { SetValue(DescricaoProperty, value); }
        }
        public Color BoxViewColor {
            get { return (Color)GetValue(BoxViewColorProperty); }
            set { SetValue(BoxViewColorProperty, value); }
        }*/

        public CardDiretor()
        {
            InitializeComponent();
        }
    }
}