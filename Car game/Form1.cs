using System.Media;

namespace Car_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        bool isqaz = false;
        bool isr = false;
        //SoundPlayer sp= new SoundPlayer("C:\\Users\\Student.STD\\Downloads\\sound.wav");
        private void button1_Click(object sender, EventArgs e)
        { 
            //sp.Play();
            isqaz = true;
            timer1.Start();

        }
        //ireli aparir
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isqaz == true && car.Location.Y > 0)
            {
                car.Location = new Point(car.Location.X, car.Location.Y - 1);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sp.Stop();
            timer1.Stop();
            timer2.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            isqaz = false;
            isr = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isr == true && car.Location.Y <= 609)
            {
                car.Location = new Point(car.Location.X, car.Location.Y + 1);
            }
            else
            {
                timer2.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isqaz == true && car.Location.X - 220 > 10)
            {
                car.Location = new Point(car.Location.X - 220, car.Location.Y);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isqaz == true && car.Location.X < 225)
            {
                car.Location = new Point(car.Location.X + 220, car.Location.Y);

            }
        }
    }
}
