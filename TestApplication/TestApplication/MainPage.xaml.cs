using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApplication
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            life.Text = count.ToString();
            infect.Text = startinf.ToString();
            commander.Text = startcomm.ToString();
        }

        int count = 40;
        int startinf = 0;
        int startcomm = 0;

        void Start_New(object sender, System.EventArgs e)
        {
            count = 40;
            startinf = 0;
            startcomm = 0;

            life.Text = count.ToString();
            infect.Text = startinf.ToString();
            commander.Text = startcomm.ToString();
        }

        void lifeMinus_Clicked(object sender, System.EventArgs e)
        {
            count--;
            life.Text = count.ToString();
        }

        void lifePlus_Clicked(object sender, System.EventArgs e)
        {
            count++;
            life.Text = count.ToString();
        }

        void infectMinus_Clicked(object sender, System.EventArgs e)
        {
            startinf--;
            infect.Text = startinf.ToString();
        }

        void infectPlus_Clicked(object sender, System.EventArgs e)
        {
            startinf++;
            infect.Text = startinf.ToString();
        }

        void commMinus_Clicked(object sender, System.EventArgs e)
        {
            startcomm--;
            commander.Text = startcomm.ToString();
        }

        void commPlus_Clicked(object sender, System.EventArgs e)
        {
            startcomm++;
            commander.Text = startcomm.ToString();
        }
    }
}
