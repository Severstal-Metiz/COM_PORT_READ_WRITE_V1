using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp4
{
    public partial class Form1
    {

        //string buferString;
        bool flag = true;

        //Открытие порта для работы
        void openPort()
        {

            if (!port.IsOpen)
            {
                port.Open();
                if (port.IsOpen)
                {
                    Message.WriteLine("Port is open");
                    timer1.Start();
                }
            }
            else
            {
                Message.WriteLine("Port already open");
            }

        }

        //Закрытие порта 
        void closePort()
        {
            if (port.IsOpen)
            {
                port.Close();
                if (!port.IsOpen)
                {
                    //flag = false;
                    Message.WriteLine("Port is close");
                    timer1.Stop();
                }
            }
            else
            {
                Message.WriteLine("Port already close");
            }
        }

        //Передача данных
        void SendData()
        {
            //port.Write(arduinoreqstring);
            port.Write(TBmessageToSend.Text+port.NewLine);
        }





    }
}
