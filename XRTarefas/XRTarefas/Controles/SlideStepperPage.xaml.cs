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
	public partial class SlideStepperPage : ContentPage
	{
		public SlideStepperPage ()
		{
			InitializeComponent ();
		}

        private void ActionValorMudou(object sender, ValueChangedEventArgs args)
        {
            SlideResult.Text = args.NewValue.ToString();
        }

        private void ActionValorMudouStepper(object sender, ValueChangedEventArgs e)
        {
            StepperResult.Text = e.NewValue.ToString();
        }
    }
}