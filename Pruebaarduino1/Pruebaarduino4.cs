using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Net.Sockets;


namespace Pruebaarduino1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static string datoarduino { get; set; } = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {

            datoarduino = "";

            butOn.Enabled = false;
            butOff.Enabled = false;
            comboSerial.Text = "9600";
            Pot1.StartAngle = 175;  //angulo de inicicio,siendo 270 la parte superior
            Pot2.StartAngle = 109;
            Pot3.StartAngle= 80;

            string[] portList = SerialPort.GetPortNames();
            comboPuerto.Items.AddRange(portList);
            progressBarConeccion.Value = 0;
            textBoxG1.Enabled = false;
            textBoxG2.Enabled = false;
            textBoxG3.Enabled = false;
            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            textBoxZ.Enabled = false;
            button1.Enabled = false;

        }


        private void butConectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboPuerto.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboSerial.Text);
                    serialPort1.Open();

                    butConectar.Text = "Desconectar";
                    progressBarConeccion.Value = 100;

                    butRefrescar.Enabled = false;
                    butOn.Enabled = true;
                    butOff.Enabled = false;
                    comboSerial.Enabled = false;
                    comboPuerto.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    serialPort1.WriteLine("$Off");
                    label1.BackColor = Color.White;
                    label1.Text = "LED";
                    serialPort1.Close();


                    butConectar.Text = "Conectar";
                    progressBarConeccion.Value = 0;
                    label1.BackColor = Color.White;
                    label1.Text = "LED";

                    butRefrescar.Enabled = true;
                    butOn.Enabled = false;
                    butOff.Enabled = false;
                    comboSerial.Text = "9600";
                    comboSerial.Enabled = true;
                    comboPuerto.Enabled = true;
                    textBoxG1.Text = "";
                    textBoxG2.Text = "";
                    textBoxG3.Text = "";
                    textBoxX.Text = "";
                    textBoxY.Text = "";
                    textBoxZ.Text = "";
                    chart1.Series["Seccion1"].Points.Clear();
                    chart1.Series["Seccion2"].Points.Clear();
                    chart1.Series["Seccion3"].Points.Clear();
                    chart2.Series["Seccion1"].Points.Clear();
                    chart2.Series["Seccion2"].Points.Clear();
                    chart2.Series["Seccion3"].Points.Clear();
                    button1.Enabled = false;
                    

                }
                   
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        

        private void butOn_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    label1.BackColor = Color.Lime;
                    serialPort1.WriteLine("$On");
                    //label1.Text = "Prendido";
                    butOn.Enabled = false;
                    butOff.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void butOff_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    label1.BackColor = Color.Red;
                    serialPort1.WriteLine("$Off");
                    //label1.Text = "Apagado";
                    butOn.Enabled = true;
                    butOff.Enabled = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("$Off");
                    label1.BackColor = Color.White;
                    label1.Text = "LED";

                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboPuerto.Items.Clear();
            comboPuerto.Text = "";
            comboPuerto.DataSource = null;
            comboPuerto.Items.AddRange(portList);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            while(serialPort1.IsOpen && serialPort1.BytesToRead >0)
            {
                string datoarduino2= serialPort1.ReadLine();

                datoarduino = datoarduino2;
                //int valor = Convert.ToInt32(datoarduino);
                int position = datoarduino.IndexOf("P1");
                int position2 = datoarduino.IndexOf("#");
                int position3 = datoarduino.IndexOf("?");
                int position4 = datoarduino.IndexOf("=");
                int position5= datoarduino.IndexOf("$");
                int position6= datoarduino.IndexOf("&");

                textBox1.Invoke((MethodInvoker)(() =>
                {
                    if (position6 >= 0)
                    {
                        textBox1.Text = datoarduino + "   " + position + " , " + position2 + " , " + position3 + " , " + position4 + " , " + position5 + " , " + position6;
                    }

                }));
                string ang1 = "";
                string ang2 = "";
                string ang3 = "";
                string cor1 = "";
                string cor2 = "";
                string cor3 = "";

                if (position >= 0 && position2 >= 0 && position3 >= 0 && position4 >= 0 && position5 >= 0 && position6 >= 0)
                {
                    
                        datoarduino = datoarduino2;
                        ang1 = datoarduino.Substring(position + 2, position2 - position - 2);
                        ang2 = datoarduino.Substring(position2 + 1, position3 - position2 - 1);
                        ang3 = datoarduino.Substring(position3 + 1, position4 - position3 - 1);
                        cor1 = datoarduino.Substring(position4 + 1, position5 - position4 - 1);
                        cor2 = datoarduino.Substring(position5 + 1, position6 - position5 - 1);
                        cor3 = datoarduino.Substring(position6 + 1);

                }

                if (ang1.Length > 0)
                {
                    textBoxG1.Invoke((MethodInvoker)(() =>
                {
                            textBoxG1.Text = ang1;
                            Pot1.Invoke((MethodInvoker)(() =>
                            {
                                int eje1 = Convert.ToInt32(ang1);
                                Pot1.Value = 360 - eje1;
                                //Pot1.Text = textBoxG1.Text;    //Me devuelve el valor obtenido del arduino
                                Pot1.Text = Convert.ToString(eje1 - 175);

                            }));
                }));
                }

                if (ang2.Length > 0)
                {
                    textBoxG2.Invoke((MethodInvoker)(() =>
                    {
                            textBoxG2.Text = ang2;
                            Pot2.Invoke((MethodInvoker)(() =>
                            {
                                int eje2 = Convert.ToInt32(ang2);
                                Pot2.Value = 360 - eje2;
                                //Pot2.Text = textBoxG2.Text; //Me devuelve el valor obtenido del arduino
                                Pot2.Text = Convert.ToString(eje2 - 109);
                            }));
                    }));
                }

                if (ang3.Length > 0)
                {
                    textBoxG3.Invoke((MethodInvoker)(() =>
                    {
                            int eje3 = Convert.ToInt32(ang3) - 80;
                            textBoxG3.Text = Convert.ToString(eje3);
                            Pot2.Invoke((MethodInvoker)(() =>
                            {
                                Pot3.Value = 360 - eje3 - 80;
                                //Pot2.Text = textBoxG2.Text; //Me devuelve el valor obtenido del arduino
                                Pot3.Text = Convert.ToString(eje3);



                            }));

                }));
            }

                if (cor1.Length > 0)
                {
                    textBoxX.Invoke((MethodInvoker)(() =>
                    {
                            textBoxX.Text = cor1;
                    }));
                }

                if (cor2.Length > 0)
                {
                    textBoxY.Invoke((MethodInvoker)(() =>
                    {
                                textBoxY.Text = cor2;
                            
                    }));

                }
                if (cor3.Length > 0)
                {
                    textBoxZ.Invoke((MethodInvoker)(() =>
                    {
                            textBoxZ.Text = cor3;
                    }));
                }

                if (ang3.Length > 0 && ang2.Length > 0 && cor3.Length > 0)
                {
                    chart2.Invoke((MethodInvoker)(() =>
                    {
                        chart2.Series["punto"].Points.AddXY(-30, 35);
                        chart2.Series["punto"].Points.AddXY(30, -35);
                        chart2.Series["Seccion1"].Points.Clear();
                        chart2.Series["Seccion2"].Points.Clear();
                        chart2.Series["Seccion3"].Points.Clear();
                        double yy2 = Math.Sin((Convert.ToDouble(ang2) - 109) * Math.PI / 180) * 15;
                        double xx2 = Math.Cos((Convert.ToDouble(ang2) - 109) * Math.PI / 180) * 15;
                        double zz = Convert.ToDouble(cor3);
                        double xx3 = Math.Cos(((Convert.ToDouble(ang3) - 80 + Convert.ToDouble(ang2) - 109) * Math.PI / 180)) * 10;

                        chart2.Series["Seccion2"].Points.AddXY(xx2, yy2 + 5);
                        chart2.Series["Seccion3"].Points.AddXY(xx2, yy2 + 5);
                        chart2.Series["Seccion3"].Points.AddXY(xx2 + xx3, zz);
                        chart2.Series["Seccion1"].Points.AddXY(0, 0);
                        chart2.Series["Seccion1"].Points.AddXY(0, 5);
                        chart2.Series["Seccion2"].Points.AddXY(0, 5);


                    }));
                }
                if (ang1.Length > 0 && ang2.Length > 0 && cor1.Length > 0 && cor2.Length > 0)
                {
                    chart1.Invoke((MethodInvoker)(() =>
                    {
                        chart1.Series["punto"].Points.AddXY(-30, 30);
                        chart1.Series["punto"].Points.AddXY(30, -30);
                        chart1.Series["Seccion2"].Points.Clear();
                        chart1.Series["Seccion3"].Points.Clear();
                        double yy2 = Math.Sin((Convert.ToDouble(ang1) - 175) * Math.PI / 180) * Math.Cos((Convert.ToDouble(ang2) - 109) * Math.PI / 180) * 15;
                        double xx2 = Math.Cos((Convert.ToDouble(ang1) - 175) * Math.PI / 180) * Math.Cos((Convert.ToDouble(ang2) - 109) * Math.PI / 180) * 15;
                        double xx3 = Convert.ToDouble(cor1);
                        double yy3 = Convert.ToDouble(cor2);
                        chart1.Series["Seccion2"].Points.AddXY(xx2, yy2);
                        chart1.Series["Seccion3"].Points.AddXY(xx2, yy2);
                        chart1.Series["Seccion3"].Points.AddXY(xx3, yy3);

                        chart1.Series["Seccion2"].Points.AddXY(0, 0);

                    }));
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string datoarduino = serialPort1.ReadLine();
            //int valor = Convert.ToInt32(datoarduino);
            int position = datoarduino.IndexOf("P1");
            int position2 = datoarduino.IndexOf("#");
            int position3 = datoarduino.IndexOf("?");
            int position4 = datoarduino.IndexOf("=");
            
            if (position >= 0 && position2 > position - 2 && position3 > position2 - 1 && position4 > position3 - 1)
            {
                try
                {
                    string g1 = datoarduino.Substring(position + 2, position2 - position - 2);
                    string g2 = datoarduino.Substring(position2 + 1, position3 - position2 - 1);
                    string g3 = datoarduino.Substring(position3 + 1, position4 - position3 - 1);
                    g1 = Convert.ToString((Convert.ToDouble(g1)-175) * Math.PI / 180);
                    g2 = Convert.ToString((Convert.ToDouble(g2)-109) * Math.PI / 180);
                    g3 = Convert.ToString((Convert.ToDouble(g3)-80) * Math.PI / 180);
                    g1=g1.Replace(",", ".");
                    g2=g2.Replace(",", ".");
                    g3=g3.Replace(",", ".");
                    Socket conexion = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress ip = IPAddress.Parse(comboIP.Text); //192.168.1.195 robot 192.168.0.16 hercules
                    IPEndPoint destino = new IPEndPoint(ip, Convert.ToInt32(textBoxPuerto.Text));
                    conexion.Connect(destino);
                    byte[] mensaje = Encoding.ASCII.GetBytes("MOVE_JOINTS:" + g1 +"," + g2 + "," + g3 +",0,0,0");
                    conexion.Send(mensaje);
                    conexion.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


            
        }
    }
}
