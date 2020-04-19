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
        private bool verboseoutput = false;

        private void toggleverbosebutton_Click(object sender, EventArgs e)
        {
            verboseoutput = !verboseoutput;
            if (verboseoutput)
            {
                toggleverbosebutton.BackColor = Color.ForestGreen;
            }
            else
            {
                toggleverbosebutton.BackColor = Color.Red;
            }
        }

        public Form1()
        {
            InitializeComponent();
            System.Console.WriteLine("Starting up...");
            optiontypebox.Items.Add("Call");
            optiontypebox.Items.Add("Put");
        }
        //calculate options tab
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
        //calculate 2% rule tab
        private void calculaterulebutton_Click(object sender, EventArgs e)
        {
            twopercentoutputbox.Clear();
            //did u leave textboxes empty?
            if (string.IsNullOrWhiteSpace(acctvaluetextbox.Text) || string.IsNullOrWhiteSpace(ppstextbox.Text) || string.IsNullOrWhiteSpace(stoplosspricetextbox.Text))
            {
                twopercentoutputbox.AppendText("Please fill out all the boxes!");
                twopercentoutputbox.AppendText(Environment.NewLine);
                return;
            }
            //gather variables
            double acctvalue = Convert.ToDouble(acctvaluetextbox.Text);
            double pps = Convert.ToDouble(ppstextbox.Text);
            double stoplossprice = Convert.ToDouble(stoplosspricetextbox.Text);
            //calculate
            double twopercent = 0.02 * acctvalue;
            double stoplossvalue = pps - stoplossprice;
            double risk = twopercent / stoplossvalue;
            //sanity check
            if (pps > twopercent)
            {
                twopercentoutputbox.AppendText("The price of this stock is a little too high for your account...");
                twopercentoutputbox.AppendText(Environment.NewLine);
                return;
            }
            if (stoplossprice > pps)
            {
                twopercentoutputbox.AppendText("Your stoploss is greater than your price per share... are you shorting? (if so just reverse your stoploss and pps!)");
                twopercentoutputbox.AppendText(Environment.NewLine);
                return;
            }
            //display
            if (verboseoutput)
            {
                twopercentoutputbox.AppendText("Amount you can risk with 2% rule: $" + twopercent);
                twopercentoutputbox.AppendText(Environment.NewLine);
                twopercentoutputbox.AppendText("At $" + pps + " per share, risk " + Math.Floor(risk) + " shares");
                twopercentoutputbox.AppendText(Environment.NewLine);
                twopercentoutputbox.AppendText("Total loss at stopout = $" + stoplossvalue * Math.Floor(risk));
                twopercentoutputbox.AppendText(Environment.NewLine);
                twopercentoutputbox.AppendText("Always set a stop loss! :)");
                twopercentoutputbox.AppendText(Environment.NewLine);
            }
            else
            {
                twopercentoutputbox.AppendText("Risk: $" + twopercent);
                twopercentoutputbox.AppendText(Environment.NewLine);
                twopercentoutputbox.AppendText(Math.Floor(risk) + " shares");
                twopercentoutputbox.AppendText(Environment.NewLine);
                twopercentoutputbox.AppendText("Max Loss = $" + stoplossvalue * Math.Floor(risk));
                twopercentoutputbox.AppendText(Environment.NewLine);
            }
        }
    }
}
