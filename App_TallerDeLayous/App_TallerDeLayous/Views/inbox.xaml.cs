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
    public partial class inbox : ContentPage
    {
        public ObservableCollection<Student> Students { get; set; }
        public inbox()
        {
            InitializeComponent();
            Students = new ObservableCollection<Student>
            {
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},
            new Student {FirstName = "John Doe", activo="https://cdn-icons-png.flaticon.com/512/594/594846.png", foto= "https://cdn-icons-png.flaticon.com/512/64/64572.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="https://cdn-icons-png.flaticon.com/512/892/892666.png", mensaje= "Today, 12 AM"},

            };
            this.BindingContext = this;
        }
    }
}