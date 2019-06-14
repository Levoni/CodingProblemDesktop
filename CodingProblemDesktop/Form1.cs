using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingProblemDesktop
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            string EventText = ProcessEvent(numericUpDown1.Value,comboBox1.SelectedItem.ToString());
            textBox1.Text = EventText;
        }

        private string ProcessEvent(decimal amount, string eventType)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            IEvent tempEvent = new Register();

            if (eventType == "Register")
            {
                tempEvent = new Register();
            }
            else if (eventType == "Diagnose")
            {
                tempEvent = new Diagnose();
            }
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                sb.AppendLine(tempEvent.ReadIntAndPrint(i));
            }

            return sb.ToString();
        }
    }
}
