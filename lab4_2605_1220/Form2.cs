using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2605_1220
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SetReceiveMessage(string message)
        {
            int charcode;
            string bitstring;
            char[] message_letter = "00000000".ToCharArray();
            char letter;
            for (int i = 0; i < message.Length/11; i++) 
            {
                if (message[i * 11] == '0' && message[i * 11 +9] == '1' && message[i * 11 +10] == '1')
                {
                    for (int j = 0; j < 8; j++)
                    {
                        message_letter[j] = message[i * 11 + 1 + j];
                    }
                    bitstring = new string(message_letter);
                    charcode = Convert.ToInt32(bitstring, 2);
                    letter = (char)charcode;
                    textbox_receive_message.Text += letter;
                }

            }
        }
    }
}
