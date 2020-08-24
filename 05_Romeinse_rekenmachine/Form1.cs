using System;
using System.Windows.Forms;


namespace _05_Romeinse_rekenmachine
{
    
    public partial class Form1 : Form
    {
        bool operatorActive = false;
        string operation = "";

        public const string NULLA = "NULLA";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = Roman.ToRoman(4);
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            operatorActive = true;
            Button b = (Button)sender;

            string newOperation = b.Text;

            lbl_calc.Text = $"{lbl_calc.Text} {textBox.Text} {newOperation}";

            //lbl_dec.Text = Roman.FromRoman(textBox.Text).ToString();
            lbl_dec.Text = Roman.FromRoman(textBox.Text).ToString();

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

        private void btn_eq_Click(object sender, EventArgs e)
        {

        }
    }
}
