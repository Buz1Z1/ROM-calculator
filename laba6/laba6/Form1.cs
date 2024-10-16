namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            bool check = true;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] >= '0' && a[i] <= '9')
                    check = true;
                else
                {
                    check = false;
                    break;
                } 
                    
            }
            if (check == true)
            {
                string result = Converter.ConvToROME(a);

                textBox3.Text = result;
            }
            else
            { 
                MessageBox.Show("Некорректный ввод");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = textBox2.Text;
                int result = Converter.ConvToInt(a);
                textBox4.Text = Convert.ToString(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректный ввод");
                textBox2.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Converter.ConvToInt(textBox5.Text);
                int b = Converter.ConvToInt(textBox6.Text);
                string result;
                switch (comboBox1.Text)
                {
                    case "+":
                        {
                            a = a + b;
                            result = a.ToString();
                            textBox7.Text = Converter.ConvToROME(result);
                            break;
                        };
                    case "-":
                        {
                            a = a - b;
                            result = a.ToString();
                            textBox7.Text = Converter.ConvToROME(result);
                            break;
                        }
                    case "*":
                        {
                            a = a * b;
                            result = a.ToString();
                            textBox7.Text = Converter.ConvToROME(result);
                            break;
                        }
                    case "/":
                        {
                            double resc = a / b;
                            double reso = a % b;
                            result = resc.ToString();
                            textBox7.Text = Converter.ConvToROME(result);
                            result = reso.ToString();
                            textBox8.Text = Converter.ConvToROME(result);
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некорректный ввод");
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            {
                int a = Converter.ConvToInt(textBox5.Text);
                int b = Converter.ConvToInt(textBox6.Text);
                if (a > b)
                    textBox7.Text = $"{Converter.ConvToROME(a.ToString())} > {Converter.ConvToROME(b.ToString())}";
                else
                    textBox7.Text = $"{Converter.ConvToROME(a.ToString())} < {Converter.ConvToROME(b.ToString())}";
                if (a == b)
                    textBox7.Text = $"{Converter.ConvToROME(a.ToString())} = {Converter.ConvToROME(b.ToString())}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Неправильный ввод");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}