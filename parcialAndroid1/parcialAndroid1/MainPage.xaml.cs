using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace parcialAndroid1
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
            Children.Add(new Equipo());
            Children.Add(new AgregarPage());
            Children.Add(new EmpleadoPage());
		}
	}
}
