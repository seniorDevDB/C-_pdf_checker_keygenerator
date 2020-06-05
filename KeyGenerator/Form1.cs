using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGenerator
{
    public partial class Form1 : Form
    {
        public int sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string hardwareID = hardwareId.Text;
            for (int i = 0; i < hardwareID.Length; i++)
            {
                sum += (int)hardwareID[i];
            }
            Console.WriteLine(sum);
            codeLabel.Text = sum.ToString();
            sum = 0;
        }
    }
}
