namespace WinFormsApp1
{
    public partial class shubhank : Form
    {
        public shubhank()
        {
            InitializeComponent();
        }
        string CalTotal;
        string option;
        int num1;
        int num2;
        int result;

        private void shubhank_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void b1_Click_1(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b9.Text;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            dwivedi.Text = dwivedi.Text + b0.Text;
        }

        private void bp_Click(object sender, EventArgs e)
        {
            //dwivedi.Text = dwivedi.Text + bp.Text;
            option = "+";
            num1 = int.Parse(dwivedi.Text);
            dwivedi.Clear();


        }

        private void bm_Click(object sender, EventArgs e)
        {
            //dwivedi.Text = dwivedi.Text + bm.Text;
            option = "-";
            num1 = int.Parse(dwivedi.Text);
            dwivedi.Clear();
        }

        private void bmu_Click(object sender, EventArgs e)
        {
            //dwivedi.Text = dwivedi.Text + bmu.Text;
            option = "*";
            num1 = int.Parse(dwivedi.Text);
            dwivedi.Clear();
        }

        private void bd_Click(object sender, EventArgs e)
        {
            //dwivedi.Text = dwivedi.Text + bd.Text;
            option = "/";
            num1 = int.Parse(dwivedi.Text);
            dwivedi.Clear();
        }

        private void bc_Click(object sender, EventArgs e)
        {
           // dwivedi.Text = dwivedi.Text + bc.Text;
            dwivedi.Clear();
            result = (0);
            num1 = 0;
            num2= 0;    

        }

        private void ba_Click(object sender, EventArgs e)
        {
            //dwivedi.Text = dwivedi.Text + ba.Text;
            num2 = int.Parse(dwivedi.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;

            dwivedi.Text = result + ""; 

        }

    }
}
