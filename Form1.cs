using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            if (tbAddItems.Text == "Type & Enter to Add Tasks")
            {
            tbAddItems.Text = "";
            }

        }

        private void tbAddItems_Leave(object sender, EventArgs e)
        {
            if (tbAddItems.Text == "")
            {
            tbAddItems.Text = "Type & Enter to Add Tasks";
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

        private void clbToDoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int prevSelectedItem = clbToDoList.SelectedIndex;
            if (prevSelectedItem != -1)
            {
            clbCompletedTasks.Items.Add(clbToDoList.SelectedItem.ToString());
                clbCompletedTasks.SetItemChecked(clbCompletedTasks.Items.Count - 1,true);
            
                this.BeginInvoke((MethodInvoker)delegate
                {
                clbToDoList.Items.RemoveAt(prevSelectedItem);
                });
                
            }

        }

        private void clbCompletedTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int prevSelectedItem = clbCompletedTasks.SelectedIndex;
            if (prevSelectedItem != -1)
            {
                clbToDoList.Items.Add(clbCompletedTasks.SelectedItem.ToString());

                this.BeginInvoke((MethodInvoker)delegate
                {
                    clbCompletedTasks.Items.RemoveAt(prevSelectedItem);
                });

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clbCompletedTasks.SelectedIndex != -1)
            {
            clbCompletedTasks.Items.Remove(clbCompletedTasks.SelectedItem);
            }
            else if(clbToDoList.SelectedIndex != -1)
            {
                clbToDoList.Items.Remove(clbToDoList.SelectedItem);
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clbToDoList.Items.Clear();
            clbCompletedTasks.Items.Clear();
        }
    }
}
