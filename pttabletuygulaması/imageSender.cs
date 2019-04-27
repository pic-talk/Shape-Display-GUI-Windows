using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pttabletuygulaması
{
    public partial class imageSender : Form
    {
        int x = 0;
        int y = 0;
        bool mouse = false;

        SerialPort serialport;
        List<Tuple<Bitmap,string>> images = new List<Tuple<Bitmap,string>>();

        int counter = 0;
        bool controller = true;


        public imageSender()
        {
            InitializeComponent();
        }

        private void imageSender_Load(object sender, EventArgs e)
        {
            images.Add(new Tuple<Bitmap, string>(pttabletuygulaması.Properties.Resources.char_pikachu, ":00770000700880008000999996609797967099999080999900899999000999990&"));
            images.Add(new Tuple<Bitmap, string>(pttabletuygulaması.Properties.Resources.rcLxGBBni, ":00000000009900990999999999999999999999999099999900099990000099000&"));
            images.Add(new Tuple<Bitmap, string>(pttabletuygulaması.Properties.Resources.cube, ":00000000000000000009999000099990000999900009999000000000000000000&"));
            timer1.Interval = 2;
        }

        public void setSerial(SerialPort port)
        {
            serialport = port;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            mouse = true;
 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (mouse)
                {
                    if (y - e.Y > (pictureBox1.Size.Height / 2) || x - e.X > (pictureBox1.Size.Width / 2))
                    {
                        if (controller)
                        {
                            Console.WriteLine("Swipe Detected");

                            timer1.Start();
                            Console.WriteLine(images[counter].Item2);
                            try
                            {
                                
                                serialport.Write(images[counter].Item2);
                              
                            }
                            catch
                            {

                            }
                            controller = false;

                        }

                    }

                }
            }
            catch
            {

            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            controller = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < images.Count()-1)
            {
                counter++;
                pictureBox1.Image = images[counter].Item1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                pictureBox1.Image = images[counter].Item1;

            }
        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Math.Abs(pictureBox1.Location.Y) > pictureBox1.Size.Height){
                timer1.Stop();
                pictureBox1.Location = new Point(0, 0);
                pictureBox1.Image = null;
            }
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10)));



        }
    }
}
