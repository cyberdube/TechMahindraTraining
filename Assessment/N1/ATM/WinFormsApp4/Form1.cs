namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        string option;
        int num1;
        int num2 = 1234;
        int num3;
        int result = 0;
        int init = 5000;


        private void b1_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b1.Text;

        }

        private void b2_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b9.Text;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            ti.Text = ti.Text + b0.Text;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            option = "ans";
            num1 = int.Parse(ti.Text);
            ti.Clear();
            {
                if (num1 == num2)
                {
                    to.Text = "Correct Pin";

                    tc.Text = "Withdraw Cash\n OR  Deposit Cash\n";


                    // Console.Write("4,20,000");
                }

                else
                {
                    to.Text = "Incorrect Pin";


                }




            }
            // to.Clear();
        }

        private void bw_Click(object sender, EventArgs e)
        {



            to.Clear();
            //num2 = int.Parse(dwivedi.Text);
            num3 = int.Parse(ti.Text);
            result = init - num3;
            to.Text = result + "";


            /** if (option.Equals("-"))
                 result = num1 - num2;
             if (option.Equals("*"))
                 result = num1 * num2;
             if (option.Equals("/"))
                 result = num1 / num2;**/

            //dwivedi.Text = result + "";



        }

        private void bd_Click(object sender, EventArgs e)
        {


            to.Clear();
            //num2 = int.Parse(dwivedi.Text);
            num3 = int.Parse(ti.Text);
            result = init + num3;
            to.Text = result + "";


            /**num2 = int.Parse(dwivedi.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;

            dwivedi.Text = result + "";**/
        }

        private void to_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
