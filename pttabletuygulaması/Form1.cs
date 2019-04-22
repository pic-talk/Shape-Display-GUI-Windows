using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pttabletuygulaması
{
    public partial class Form1 : Form
    {
        List<string> models = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "ptsd files |*.ptsd";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select your model file.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(dialog.FileName);

                for (int i = 4; i < lines.Length; i++)
                {
                    var splitted = lines[i].Split('/');
                    comboBox2.Items.Add(splitted[0]);
                    models.Add(splitted[1]);
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(models[comboBox2.SelectedIndex]);
        }

        private void button_baglan_Click(object sender, EventArgs e)
        {
            if (button_baglan.Text == "Connect")
            {
                if (comboBox_seriport.Text != "")
                {

                    try
                    {
                        serialPort1.BaudRate = 115200;
                        serialPort1.PortName = comboBox_seriport.Text;
                        serialPort1.Open();
                        button_baglan.Text = "Disconnect";
                        label_seridurum.Text = "Connected";
                        label_seridurum.ForeColor = Color.Green;
                        button_baglan.ForeColor = Color.Red;
                        Task.Run(() => resetDevice());
                       

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
            }

            else
            {
                try
                {
                    serialPort1.Write(":ax&");
                    serialPort1.Close();
                    button_baglan.Text = "Connect";
                    label_seridurum.Text = "No Connection";
                    label_seridurum.ForeColor = Color.Red;
                    button_baglan.ForeColor = Color.Green;

                }
                catch (Exception)
                {

                }

            }
        }

        private void resetDevice()
        {
            System.Threading.Thread.Sleep(1000);
            serialPort1.Write(":08888888888888888888888888888888888888888888888888888888888888888&");
            System.Threading.Thread.Sleep(5000);
            serialPort1.Write(":00000000000000000000000000000000000000000000000000000000000000000&");

        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            comboBox_seriport.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())  //Installing Serial Ports to Program
            {
                comboBox_seriport.Items.Add(item);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in SerialPort.GetPortNames())  //Installing Serial Ports to Program
            {
                comboBox_seriport.Items.Add(item);
        
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                richTextBox1.Text += serialPort1.ReadLine();

            }
            catch
            {

            }
        }

        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox1.Text);

            }
            catch
            {

            }
        }
    }
}