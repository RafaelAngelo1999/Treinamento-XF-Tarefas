using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XRTarefas.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}
        private void Modificar(object sender, EventArgs args)
        {
            Bar1.Progress = 1;
            Bar2.ProgressTo(1, 10000, Easing.Linear);
            Bar3.ProgressTo(1, 10000, Easing.SpringIn);
            Bar4.ProgressTo(1, 10000, Easing.SinIn);
            Bar5.ProgressTo(1, 10000, Easing.BounceOut);
            Bar6.ProgressTo(1, 10000, Easing.BounceIn);
            Bar7.ProgressTo(1, 10000, Easing.CubicIn);

        }
    }
}