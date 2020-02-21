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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();
            //image1.IsLoading
            Image image = new Image();
            image.Source =  "https://e3ba6e8732e83984.cdn.gocache.net/uploads/image/file/1223025/large_ce8483775a488f6a0b1d6c5dc0f3a4fe.png";
             Container.Children.Add(image);
		}
	}
}