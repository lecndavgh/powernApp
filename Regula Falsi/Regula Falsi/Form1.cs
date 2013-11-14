using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;


namespace Regula_Falsi
{
    public partial class Form1 : Form
    {
        Thread thread;
        SerialPort sp;
        int c;
        int a = 0;
        int x;
        string w;
        int omax;
        int nmax;
        int max;
        double ot;
        double nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            omax = 0;
            c = 0;
            w = "";
            ot = 0;
            //Show all COM Ports
            foreach (string com in SerialPort.GetPortNames())
            {
                cmb_com.Items.Add(com);
            }
            //
        }

        void receiver()
        {
            double t = 0;
            bool up = false;
            bool m = false;
            x = 0;
            double f;

            while (true)
            {
                a++;
                string input = sp.ReadLine();
                double u;
                try
                {
                    u = Convert.ToDouble(input);
                    w += c.ToString() + ";" + u.ToString() + "\n";

                    Invoke((Action)delegate
                    {
                        lbl_log.Items.Add(u.ToString());
                        lbl_log.SelectedIndex = lbl_log.Items.Count - 1;

                        ////Frequenzberechnung
                        //nmax = (int)u;
                        //if (nmax > omax)
                        //{
                        //    m = true;
                        //    omax = nmax;
                        //}
                        //if ((nmax < omax) && m)
                        //{
                        //    m = false;

                        //    nt = Environment.TickCount;
                        //    f = 1 / ((nt - ot) / 1000);
                        //    ot = nt;
                        //    label1.Text = "Frequenz: " + f.ToString() + " Hz";

                        //    max = omax;
                        //    omax = 0;
                        //}
                        
                        //Frequenz für Herzschlag
                        if (u > 600)
                        {
                            up = true;
                        }
                        if (up && (u < 600))
                        {
                            f = 1 / (t / 100);  //100 Werte pro Sekunde //bekommene Werte mal 10 (ms) / 1000 (s, weil Hz)
                            label1.Text = "Frequenz:  " + f.ToString() + " Hz";
                            label1.Text += "        " + t.ToString();
                            t = 0;
                            up = false;
                        }
                        t++;
                        //

                        //Chart
                        if (cbx_scroll.Checked == true)
                        {
                            x++;
                            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points.Count;
                            //nur jeden zehnten Wert im Chart darstellen
                           // if (x == 0)
                           // {
                                chart1.Series[0].Points.AddXY((double)c, u);
                                x = 0;
                            //}
                            //

                            chart1.Series[1].Points.AddXY((double)c, (double)max);






                            //Autoscroll to the right
                            if ((a >= 200) && (cbx_scroll.Checked == true))
                            {
                                Invoke((Action)delegate
                                {
                                    chart1.ChartAreas[0].AxisX.ScaleView.Scroll(chart1.ChartAreas[0].AxisX.Maximum);
                                });
                            }
                            //
                        }
                        else
                        {
                            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                            chart1.ChartAreas[0].AxisX.Maximum = (double)num_num.Value;
                        }

                        c++;
                        //


                        //aktChart(c, u);

                        //Serial Buffer nach 1000 Werten leeren, da nicht so schnell gelesen werden kann
                        if (((a % 1000) == 0) && (sp.IsOpen == true))
                        {
                            sp.DiscardInBuffer();
                            sp.DiscardOutBuffer();
                        }
                        //

                       

                        
                    });
                }
                catch
                {
                    ;
                }
            }
        }

        void aktChart(double x, double y)
        {
            Invoke((Action)delegate
            {
                if (cbx_scroll.Checked == true)
                {
                    x++;
                    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points.Count;
                    //nur jeden zehnten Wert im Chart darstellen
                    if (x == 9)
                    {
                        chart1.Series[0].Points.AddXY((double)c, y);
                        x = 0;
                    }
                    //
                    //Autoscroll to the right
                    if ((a >= 200) && (cbx_scroll.Checked == true))
                    {
                        Invoke((Action)delegate
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Scroll(chart1.ChartAreas[0].AxisX.Maximum);
                        });
                    }
                    //
                }
                else
                {
                    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                    chart1.ChartAreas[0].AxisX.Maximum = (double)num_num.Value;
                }

                c++;
            });
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Disconnect")
            {
                try
                {
                    thread.Abort();
                    sp.Close();
                    a = 0;
                    x = 0;
                    c = 0;
                    btn_connect.Text = "Connect";
                    return;
                }
                catch { }
            }
            else
            {
                try
                {
                    lbl_log.Items.Clear();
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    chart1.ChartAreas[0].AxisX.ScaleView.Scroll((double)0);
                    sp = new SerialPort();
                    sp.PortName = cmb_com.Text;
                    sp.BaudRate = 9600;         //9600...Arduino Uno | 19200...Bluetooth Modul
                    sp.Parity = Parity.None;
                    sp.DataBits = 8;
                    sp.StopBits = StopBits.One;
                    sp.NewLine = "\r\n";
                    sp.Open();
                    lbl_log.Items.Add("Connected...");
                    thread = new Thread(receiver);
                    thread.IsBackground = true;
                    thread.Start();
                    btn_connect.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Es konnte keine Verbinung aufgebaut werden!");
                }
            }
        }

        private void cbx_scroll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_scroll.Checked == true)
                num_num.Enabled = false;
            else
                num_num.Enabled = true;
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("werte.txt", FileMode.Create, FileAccess.Write);
            byte[] ws = Encoding.Default.GetBytes(w);
            fs.Write(ws, 0, ws.Length);
            fs.Close();
        }

    }
}
