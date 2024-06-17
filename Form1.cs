using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbAddItems_Enter(object sender, EventArgs e)
        {
            if (tbAddItems.Text == "Type & Enter to Add Items")
            {
            tbAddItems.Text = "";
            }

        }

        private void tbAddItems_Leave(object sender, EventArgs e)
        {
            if (tbAddItems.Text == "")
            {
            tbAddItems.Text = "Type & Enter to Add Items";
            }
        }

        private void tbAddItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                clbToDoList.Items.Add(tbAddItems.Text);
                tbAddItems.Text = string.Empty;
            }
        }
    }
}
