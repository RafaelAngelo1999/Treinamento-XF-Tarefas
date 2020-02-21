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
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTI;
		public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTI = new List<String>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");
            empresasTI.Add("Otimiza");
            empresasTI.Add("UGC");

            Preencher(empresasTI);
        }


        private void Preencher(List<String> empresasTI)
        {
            ListResult.Children.Clear();

            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }

        private void Pesquisar (object sender, TextChangedEventArgs e)
        {
            var resultado = empresasTI.Where(a => a.Contains(e.NewTextValue)).ToList<String>();
            Preencher(resultado);
        }
    }
}