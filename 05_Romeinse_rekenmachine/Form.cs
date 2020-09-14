using System;
using System.Windows.Forms;

namespace _05_Romeinse_rekenmachine
{
    public partial class Form : System.Windows.Forms.Form
    {
        char operation = ' ';
        int first, second = 0;
        int result = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void Numeral_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void Update_Display()
        {
            if (first == 0)
            {
                first = Roman.FromRoman(textBox1.Text);
            }
            else if (second == 0)
            {
                second = Roman.FromRoman(textBox1.Text);
            }

            textBox1.Text = "";
            textBox2.Text = $"{first} {operation} {second}";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text.ToCharArray()[0];

            Update_Display();
        }

        private void btn_Clr_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            first = 0;
            second = 0;
            result = 0;
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            Update_Display();

            switch (operation)
            {
                case '+': result = first + second; break;
                case '-': result = first - second; break;
                case '*': result = first * second; break;
                case '/': if (first != 0) { result = first / second; }; break;
            }
            textBox2.Text = $"{Roman.ToRoman(first)} {operation} {Roman.ToRoman(second)} = {Roman.ToRoman(result)}";
            textBox2.Text += $" ({result})";

            first = 0;
            second = 0;
            result = 0;
        }
    }
}