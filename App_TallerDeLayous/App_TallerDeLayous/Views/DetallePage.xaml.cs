using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_TallerDeLayous.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePage : ContentPage
    {
        public DetallePage()
        {
            InitializeComponent();
        }
       

        private void fotos_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new fotosImagenes();
        }

        private void musica_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Page3();
        }

        private void user_Clicked(object sender, EventArgs e)
        {

        }
    }
}