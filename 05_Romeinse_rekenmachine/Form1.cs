using System;
using System.Windows.Forms;


namespace _05_Romeinse_rekenmachine
{
    
    public partial class Form1 : Form
    {
        bool operatorActive = false;
        char operation = ' ';
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            operatorActive = true;
            Button b = (Button)sender;
            char newOperation = b.Text.ToCharArray()[0];

            operation = newOperation;

            lbl_dec.Text = $"{(textBox.Text)} {operation}"; //Roman.FromRoman
        }

        private void Numeral_Click(object sender, EventArgs e)
        {
            if (operatorActive)
                textBox.Clear();

            Button b = (Button)sender;
            operatorActive = false;

            textBox.Text += b.Text;
        }

        private void Calculate(char inputOperator)
        {
            switch (inputOperator)
            {
                case '+': result = result + Roman.FromRoman(textBox.Text); break;
                case '-': result = result - Roman.FromRoman(textBox.Text); break;
                case '*': result = result * Roman.FromRoman(textBox.Text); break;
                case '/': result = result / Roman.FromRoman(textBox.Text); break;
                default: break;
            }
        }

        private void btn_eq_Click(object sender, EventArgs e)
        {
            operatorActive = true;

            Calculate(operation);

            //textBox.Text = result.ToString();

            lbl_dec.Text += $"{result}";
            //lbl_dec.Text += $" {Roman.FromRoman(textBox.Text)}";
        }
    }
}