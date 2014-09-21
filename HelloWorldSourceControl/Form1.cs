using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Upon clicking Goodbye button the user will be prompted with a message
        /// and the program will be closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoodbye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye World!");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
