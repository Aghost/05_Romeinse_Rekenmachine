using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Romeinse_rekenmachine
{
    
    public partial class Form1 : Form
    {
        bool operatorActive = false;
        string operation = "";


        public const string NULLA = "NULLA";
        string currentRom = Roman.ToRoman(999);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = currentRom;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            operatorActive = true;
            Button b = (Button)sender;

            string newOperation = b.Text;

            lbl_calc.Text = $"{lbl_calc.Text} {textBox.Text} {newOperation}";

            operation = newOperation;
        }

        private void Numeral_Click(object sender, EventArgs e)
        {
            if (operatorActive)
                textBox.Clear();

            Button b = (Button)sender;
            operatorActive = false;

            textBox.Text += b.Text;
        }
    }
}
