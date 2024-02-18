using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using IntentoMenuStoreCone.Vistas;

namespace IntentoMenuStoreCone
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master = new navegacion();
            this.Detail = new NavigationPage(new IniciarSesion());
            App.MasterDet = this;
        }
    }
}
