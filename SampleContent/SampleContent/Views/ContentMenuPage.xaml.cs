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
            TitlePage.Title = $"Bienvenido {name}";          
        }
        



        private void Frame1_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.LightYellow;
            FrameTwo.BackgroundColor = Color.Transparent;
            FrameThree.BackgroundColor = Color.Transparent;
            FrameFourth.BackgroundColor = Color.Transparent;
            FrameFive.BackgroundColor = Color.Transparent;
            FrameSix.BackgroundColor = Color.Transparent;
        }

        private void Frame2_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.Transparent;
            FrameTwo.BackgroundColor = Color.LightYellow;
            FrameThree.BackgroundColor = Color.Transparent;
            FrameFourth.BackgroundColor = Color.Transparent;
            FrameFive.BackgroundColor = Color.Transparent;
            FrameSix.BackgroundColor = Color.Transparent;
        }
    

        private void Frame3_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.Transparent;
            FrameTwo.BackgroundColor = Color.Transparent;
            FrameThree.BackgroundColor = Color.LightYellow;
            FrameFourth.BackgroundColor = Color.Transparent;
            FrameFive.BackgroundColor = Color.Transparent;
            FrameSix.BackgroundColor = Color.Transparent;
        }

        private void Frame4_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.Transparent;
            FrameTwo.BackgroundColor = Color.Transparent;
            FrameThree.BackgroundColor = Color.Transparent;
            FrameFourth.BackgroundColor = Color.LightYellow;
            FrameFive.BackgroundColor = Color.Transparent;
            FrameSix.BackgroundColor = Color.Transparent;
        }

        private void Frame5_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.Transparent;
            FrameTwo.BackgroundColor = Color.Transparent;
            FrameThree.BackgroundColor = Color.Transparent;
            FrameFourth.BackgroundColor = Color.Transparent;
            FrameFive.BackgroundColor = Color.LightYellow;
            FrameSix.BackgroundColor = Color.Transparent;
        }

        private void Frame6_Tapped(object sender, EventArgs e)
        {
            FrameOne.BackgroundColor = Color.Transparent;
            FrameTwo.BackgroundColor = Color.Transparent;
            FrameThree.BackgroundColor = Color.Transparent;
            FrameFourth.BackgroundColor = Color.Transparent;
            FrameFive.BackgroundColor = Color.Transparent;
            FrameSix.BackgroundColor = Color.LightYellow;
        }
    }
}