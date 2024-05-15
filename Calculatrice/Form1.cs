namespace Calculatrice
{
    public partial class Form1 : Form
    {
        double n1, n2, n3;
        int signe;
        Boolean controle;
        double multip1 = 0;
        double ResultFrm = 0;
        double ResultFrm1 = 0;
        double Division = 0;
        String Op = "";
        bool isOp = false;

        public Form1()

        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOp = false;
            controle = true;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else { textBox1.Text = "1"; }
            controle = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            isOp = false;
            controle = true;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else { textBox1.Text = "2"; }
            controle = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                isOp = false;

                controle = true;

                if (controle == true)
                {
                    textBox1.Text = textBox1.Text + "3";
                }
                else { textBox1.Text = "3"; }
                controle = false;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isOp = false;
            controle = true;
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                isOp = false;

                controle = true;

                if (controle == true)
                {
                    textBox1.Text = textBox1.Text + "5";
                }
                else { textBox1.Text = "5"; }
                controle = false;


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controle = true;
            isOp = false;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else { textBox1.Text = "6"; }
            controle = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            controle = true;
            isOp = false;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else { textBox1.Text = "7"; }
            controle = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controle = true;
            isOp = false;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else { textBox1.Text = "8"; }
            controle = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            controle = true;
            isOp = false;

            if (controle == true)
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else { textBox1.Text = "9"; }
            controle = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            signe = 1;
            textBox1.Clear();
            n2 = '+';
            textBox1.Text = "0";
            isOp = false;


        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            switch (Op)
            {
                case "+":
                    textBox1.Text = (ResultFrm + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (ResultFrm1 - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (Division / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (multip1 * double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {

            Op = button11.Text;
            isOp = true;

            ResultFrm = double.Parse(textBox1.Text);

            if (isOp)
            {
                textBox1.Text = "";
                isOp = false;
            }
            else
            {
                textBox1.Text += "";
            }


        }

        private void operator_click1(object sender, EventArgs e)
        {
            Op = "-";
            isOp = true;
            ResultFrm1 = double.Parse(textBox1.Text);
            textBox1.Text = "";

        }

        private void operator_click2(object sender, EventArgs e)
        {

            Op = "/";
            isOp = true;
            Division = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void multip(object sender, EventArgs e)
        {
            Op = "*";
            isOp = true;
            multip1 = double.Parse(textBox1.Text);
            textBox1.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            {
                isOp = false;

                controle = true;

                if (controle == true)
                {
                    textBox1.Text = textBox1.Text + "0";
                }
                else { textBox1.Text = "0"; }
                controle = false;


            }

        }
    }
}
