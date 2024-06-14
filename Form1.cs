namespace Cs0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int vx1 = random.Next(-10, 11);
        int vy1 = random.Next(-10, 11);

        int vx2 = random.Next(-5, 6);
        int vy2 = random.Next(-5, 6);



        int vx3 = random.Next(-5, 6);
        int vy3 = random.Next(-5, 6);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx1;
            label1.Top += vy1;
            if (label1.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            else if (label1.Left > (ClientSize.Width - label1.Width))
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label1.Top < 0)
            {
                vy1 = Math.Abs(vy1);
            }
            else if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy1 = -Math.Abs(vy1);
            }

            //

            label2.Left += vx2;
            label2.Top += vy2;
            if (label2.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            else if (label2.Left > (ClientSize.Width - label2.Width))
            {
                vx2 = -Math.Abs(vx2);
            }
            else if (label2.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            else if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy2 = -Math.Abs(vy2);

            }

            //

            label3.Left += vx3;
            label3.Top += vy3;
            if (label3.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            else if (label1.Left > (ClientSize.Width - label3.Width))
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label3.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            else if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy3 = -Math.Abs(vy3);
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}