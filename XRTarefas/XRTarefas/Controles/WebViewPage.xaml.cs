﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XRTarefas.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}
        public void GoPage(object sender, EventArgs args)
        {
            Navegador.Source = EnderecoSite.Text;
        }
        public void GoProximo(object sender, EventArgs args)
        {
            if(Navegador.CanGoForward == true)
            {
                Navegador.GoForward();
            }
        }
        public void GoVoltar(object sender, EventArgs args)
        {
            if (Navegador.CanGoBack == true)
            {
                Navegador.GoBack();
            }
        }
        public void ActionCarregando(object sender, EventArgs args)
        {
            LblStatus.Text = "Carregado";
        }
        public void ActionCarregado(object sender, EventArgs args)
        {
            LblStatus.Text = "Carregando";

        }



    }
}