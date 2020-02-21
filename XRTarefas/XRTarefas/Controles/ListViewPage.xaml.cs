using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRTarefas.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XRTarefas.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "Rafael Angelo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Gabriel Angelo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Joao Angelo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Matheus Angelo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Lucas Angelo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Guilherme Angelo", Idade = "21" });

            ListaPessoas.ItemsSource = lista;


        }

	}
}