using App_TallerDeLayous.ViewsModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_TallerDeLayous.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class contactos : ContentPage
    {
        public ObservableCollection<Student> Students { get; set; }
        public contactos()
        {
            InitializeComponent();
            Students = new ObservableCollection<Student>
            {
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png",horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png",horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png",horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png",horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png",horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", horaestado="https://cdn-icons-png.flaticon.com/512/324/324123.png", mensaje= "johndoe@site.com"},

            };
            this.BindingContext = this;
        }
    }
}