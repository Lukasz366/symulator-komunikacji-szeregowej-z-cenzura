using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2605_1220
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private List<string> censoredWords;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Show();
            LoadCensoredWords();
        }

        private void LoadCensoredWords()
        {
            censoredWords = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("cenzura.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        censoredWords.Add(line.Trim());
                    }
                    


                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not read the file 'cenzura.txt': " + e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            // Read text from send_textbox
            string textToSend = send_textbox.Text;
            textToSend = CensorText(textToSend);


            // Convert text to byte array
            byte[] byteArray = Encoding.UTF8.GetBytes(textToSend);

            // Convert each byte to bits and concatenate them
            string bitString = "";
            foreach (byte b in byteArray)
            {
                bitString += "0" + Convert.ToString(b, 2).PadLeft(8, '0') + "11";
            }

            // Display bits in receive_textbox
            receive_textbox.Text = bitString;
            form2.SetReceiveMessage(bitString);
        }


        private string CensorText(string text)
        {
            StringBuilder censoredText = new StringBuilder(text);

            foreach (string word in censoredWords)
            {
                int index = 0;
                while ((index = text.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        censoredText[index + i] = '*';
                    }
                    index += word.Length;
                }
            }

            return censoredText.ToString();
        }
    }
}
