using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3b___Basic_Input
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string name;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Click Event:

            string name = txtInput.Text;
            lblMessage.Text = "Nice to meet you " + name;



        }
    }
}
