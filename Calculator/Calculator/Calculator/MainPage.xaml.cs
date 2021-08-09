using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public int Transition = 1;
        public double FirstNumber=0;
        public double SecondNumber=0;
        public string Sign;

        public MainPage()
        {
            InitializeComponent();

            DeleteAC(this, null);

            if (NullCheck())
            {
                ResultText.Text = "0";
            }

        }

        private bool NullCheck()
        {
            if (FirstNumber == 0)
            {
                return true;
            }
            else
                return false;
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (ResultText.Text=="0" || Transition<0)
            {
                ResultText.Text = "";
            }
            this.ResultText.Text += button.Text;

            double number;
            if (double.TryParse(ResultText.Text, out number))
            {
                if (Transition == 1)
                {
                    FirstNumber = number;
                }
                else if (Transition < 1)
                {
                    SecondNumber = number;
                }
            }
        }

        private void DeleteAC(object sender, EventArgs e)
        {
            ResultText.Text = "0";
            Transition = 1;
            FirstNumber = 0;
            SecondNumber = 0;
        }

        private void Operators_Pressed(object sender, EventArgs e)
        {
            Transition = -1;
            var ButtonData = (Button)sender;
            Sign = ButtonData.Text;
        }

        private void ResultEquals(object sender, EventArgs e)
        {
            var result = OperatorClass.GetSymbol(Sign, FirstNumber, SecondNumber);
            ResultText.Text = result.ToString();
            FirstNumber = result;
            Transition = -1;
        }
    }
}
