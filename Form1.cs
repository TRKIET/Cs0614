namespace Cs0614
{
    public partial class Form1 : Form
    {
        static int ChrMax => 100;

        static Random random = new Random();
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        Label[] labels = new Label[ChrMax];//場所確保


        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {

                labels[i] = new Label();//生成
                labels[i].AutoSize = true;
                labels[i].Text = "(*_*)";
                Controls.Add(labels[i]);
                labels[i].Font = new Font(
                    "Yu Gothic UI",
                    10F,
                    FontStyle.Regular,
                    GraphicsUnit.Point);

                labels[i].Left = random.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = random.Next(ClientSize.Height - labels[i].Height);
            }


            for (int i = 0; i < ChrMax; i++)
            {

                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }
            /*
            vx[0] = random.Next(-10, 11);
            vy[0] = random.Next(-10, 11);

            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);

            vx[2] = random.Next(-10, 11);
            vy[2] = random.Next(-10, 11);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ChrMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if (labels[i].Left < 0)
                {
                    vx[0] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > (ClientSize.Width - labels[i].Width))
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Top > (ClientSize.Height - labels[i].Height))
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }
            //
            /*
            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label2.Left > (ClientSize.Width - label2.Width))
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            else if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy[1] = -Math.Abs(vy[1]);

            }

            //

            label3.Left += vx[2];
            label3.Top += vy[2];
            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label3.Left > (ClientSize.Width - label3.Width))
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            else if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }
            */
        }


        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");

                if (i == 9)
                {
                    timer1.Enabled = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if(i == 5)
                { 
                    break;
                }
                MessageBox.Show(i.ToString());
            }
            MessageBox.Show($"after{i}");
        }
    }
}