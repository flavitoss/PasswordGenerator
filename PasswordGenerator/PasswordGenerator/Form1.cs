using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                PasswordGenerator(6);
            } 
            else if(checkBox2.Checked) 
            {
                PasswordGenerator(10);
            } else if(checkBox3.Checked) 
            {
                PasswordGenerator(12);
            }
         
        }

        public void PasswordGenerator(int lenght) 
        {
            const string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ç.,!@#$%¨&*";

            StringBuilder result = new StringBuilder();
            Random random = new Random();

            while (0 < lenght--)
            {
                result.Append(validChar[random.Next(validChar.Length)]);

            }
            textBox1.Text = result.ToString();
        }
    }
    }
 


    