using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Code_Example_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = button1;
            txtInput.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int returnValue = StoredProcW_INTReturn.RunStoredProcedure(txtInput.Text);

            txtOutput.Text = returnValue.ToString();
        }
        int count;

    }

}
