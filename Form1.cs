using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockboi
{
    public partial class Form1 : Form
    {
        private double breakevenPrice, strikePrice, askPrice, currentPrice;
        public Form1()
        {
            InitializeComponent();
            System.Console.WriteLine("Starting up...");
            optiontypebox.Items.Add("Call");
            optiontypebox.Items.Add("Put");
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Calculating");
            //gather variables
            breakevenPrice = -1.0;
            currentPrice = Convert.ToDouble(currentpricebox.Text);
            strikePrice = Convert.ToDouble(strikepricebox.Text);
            askPrice = Convert.ToDouble(askpricebox.Text);
            //calculate
            if (optiontypebox.Text.Equals("Call"))
            {
                breakevenPrice = strikePrice + askPrice;
            }
            else if (optiontypebox.Text.Equals("Put"))
            {
                breakevenPrice = strikePrice - askPrice;
            }
            else
            {
                throw new Exception("If its not a call or a put what is it? I have no clue");
            }
            //display
            System.Console.WriteLine("Breakeven Price: " + breakevenPrice);
            outputbox.AppendText("Breakeven Price: " + breakevenPrice);
            outputbox.AppendText(Environment.NewLine);
            //System.Console.WriteLine("To make 5% profit: " + breakevenPrice);



            //later: Stock quotes live fetch pls

        }
    }
}
