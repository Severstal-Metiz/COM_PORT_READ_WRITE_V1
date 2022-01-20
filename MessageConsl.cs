using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class MessageConsl
    {
        TextBox textBox;
        public MessageConsl(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public void Clear() { textBox.Text = ""; }
        private void WriteLineToTB(string msg){
            textBox.Text += DateTime.Now + ":: " + msg + Environment.NewLine;
            
        }
        private void WriteToTB(string msg) {
            textBox.Text += msg;
            
        }
        public void WriteLine()
        {
            textBox.Text += Environment.NewLine;
           // textBox.ScrollToCaret();
        }
        public void WriteLine(string msg)
        {
            WriteLineToTB(msg);
        }
        public void WriteLine(byte msg)
        {
            WriteLineToTB(msg.ToString());
        }
        public void WriteLine(int msg)
        {
            WriteLineToTB(msg.ToString());
        }
        public void WriteLine(Enum msg)
        {
            WriteLineToTB(msg.ToString());
        }
        public void Write(string msg)
        {
            WriteToTB(msg);
        }
        public void Write(byte msg)
        {
            WriteToTB(msg.ToString());
        }
        public void Write(int msg)
        {
            WriteToTB(msg.ToString());
        }
        public void Write(Enum msg)
        {
            WriteToTB(msg.ToString());
        }
        
    }
}
