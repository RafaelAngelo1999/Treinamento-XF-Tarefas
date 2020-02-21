using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XRTarefas.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ActivityIndicatorPage());

        }
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());

        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.LabelPage());

        }
        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());

        }

        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());

        }
        private void GoEntryEditor(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());

        }
        private void GoDatePicker(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.DatePickerPage());

        }
        private void GoTimePicker(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TimePickerPage());

        }
        private void GoPicker(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.PickerPage());

        }
        private void GoSearchBar(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());

        }
        private void GoSliderStepper(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SlideStepperPage());

        }
        private void GoSwitch(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());

        }
        private void GoImage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ImagePage());

        }
        private void GoListView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());

        }
        private void GoTableView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());

        }

        private void GoWebView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());

        }


    }
}