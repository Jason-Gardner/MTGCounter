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
        int count = 40;
        int startinf = 0;
        int startcomm = 0;
        bool fontswitched = false;

        public MainPage()
        {
            InitializeComponent();

            life.Text = count.ToString();
            infect.Text = startinf.ToString();
            commander.Text = startcomm.ToString();
        }

        void Start_New(object sender, System.EventArgs e)
        {
            count = 40;
            startinf = 0;
            startcomm = 0;

            life.Text = count.ToString();
            infect.Text = startinf.ToString();
        }

        void lifeMinus_Clicked(object sender, System.EventArgs e)
        {
            count--;
            if (count < 1000 && fontswitched == true)
            {
                life.FontSize += 10;
                fontswitched = false;
            }
            if (count < -99 && fontswitched == false)
            {
                life.FontSize -= 10;
                fontswitched = true;
            }
            life.Text = count.ToString();
        }

        void lifePlus_Clicked(object sender, System.EventArgs e)
        {
            count++;
            if (count > 999 && fontswitched == false)
            {
                life.FontSize -= 10;
                fontswitched = true;
            }
            if (count > -100 && fontswitched == true)
            {
                life.FontSize += 10;
                fontswitched = false;
            }
            life.Text = count.ToString();
        }

        void infectMinus_Clicked(object sender, System.EventArgs e)
        {
            if (startinf > 0)
            {
                startinf--;
                infect.Text = startinf.ToString();
            }
        }

        void infectPlus_Clicked(object sender, System.EventArgs e)
        {
            startinf++;
            infect.Text = startinf.ToString();
        }

        void commMinus_Clicked(object sender, System.EventArgs e)
        {
            if (startcomm > 0)
            {
                startcomm--;
                commander.Text = startcomm.ToString();
            }
        }

        void commPlus_Clicked(object sender, System.EventArgs e)
        {
            startcomm++;
            commander.Text = startcomm.ToString();
        }
    }
}
