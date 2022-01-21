using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using static System.Math;
using System.Windows.Forms;



namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {
        MessageConsl Message;
        SerialPort port = new SerialPort();
        
        string arduinoreqstring;//Фраза запроса для ардуино
        byte[] buf = new byte[10000000];
        int ticksNumber = 0;
        public Form1()
        {
            InitializeComponent();
            Message = new MessageConsl(tBConsole);
            StartComboBoxParams();
            arduinoreqstring = "Send data"+ port.NewLine;
            btnReqArduino.Enabled = false;
        }
         

        void StartComboBoxParams()
        {
            //Массив констант скорости порта в бодах
            string[] s = SerialPort.GetPortNames();
            int bauds = 75;
            comboBox1.Items.AddRange(s);
            for (int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(bauds);
                bauds *= 2;

            }
            comboBox2.Items.Add(57600);
            comboBox2.Items.Add(115200);
            comboBox2.Items.Add(230400);
            comboBox2.Items.Add(666666);
            comboBox2.Items.Add(1000000);
            comboBox2.Items.Add(5000000);

            //Массив литров четности порта 
            string[] parityNames;
            parityNames = Enum.GetNames(typeof(Parity));
            comboBox3.Items.AddRange(parityNames);

            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(port.PortName);
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf(port.BaudRate);
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf(port.Parity.ToString());
            //Вывод настроек в консоль
            Message.Clear();
            Message.WriteLine("Стартуем, Наталья, морская пихота!!!");
            Message.WriteLine($"Значения по умолчанию DataBits: {port.DataBits}, StopBits: {port.StopBits}, ");
            Message.Write($"PortName: { port.PortName}, BaudRate: {port.BaudRate}, Parity: {port.Parity}");
            Message.WriteLine();
            comboBox1.SelectedIndex = comboBox1.Items.Count-1;
        }


        #region Кнопки
        private void BtnStart_Click(object sender, EventArgs e)
        {
            openPort();
            if (port.IsOpen)
            {
                btnReqArduino.Enabled = true;
            }
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            closePort();
            btnReqArduino.Enabled = false;
        }

        #endregion
        #region Comboxs
 private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           port.PortName =  comboBox1.SelectedItem.ToString();
           Message.WriteLine("Изменено PortName: " + comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            port.BaudRate = (int)comboBox2.SelectedItem;
            Message.WriteLine("Изменено BaudRate: " + port.BaudRate);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //port.Parity = (Parity)comboBox3.SelectedIndex;
            port.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.SelectedItem.ToString());
            //port.Parity = (Parity)comboBox3.SelectedItem;
            Message.WriteLine("Изменено Parity: " + port.Parity);
        }

        #endregion
       
        private void button1_Click(object sender, EventArgs e){Message.Clear();}
        private void Form1_FormClosed(object sender, FormClosedEventArgs e){
            closePort();
            flag = false;
        }
        private void btnReqArduino_Click(object sender, EventArgs e){SendData();}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Read1();
        }

        void Read1()
        {
            for (int i=0; i<buf.Length;i++)
            {
                buf[i] = 0;
            }
           
            port.Read(buf, 0, port.BytesToRead);
            Message.WriteLine(Encoding.UTF8.GetString(buf));
            Message.WriteLine();
            Message.WriteLine();
            
        }

        void Read2()
        {
            Message.WriteLine(port.ReadLine()); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Read1();
            SendData();
            ticksNumber++;
            label1.Text = ticksNumber.ToString();
        }
    }




}