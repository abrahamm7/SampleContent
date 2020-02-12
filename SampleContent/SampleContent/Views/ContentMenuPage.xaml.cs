using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleContent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentMenu : TabbedPage
    {
        public ContentMenu(string name)
        {
            InitializeComponent();
            MenuContentPage.Title = $"Bienvenido {name}";  
        }     
       
    }
}