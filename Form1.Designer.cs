namespace Simple_To_Do_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clbToDoList = new System.Windows.Forms.CheckedListBox();
            this.cmsCheckBoxList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAddItems = new System.Windows.Forms.TextBox();
            this.clbCompletedTasks = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsCheckBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbToDoList
            // 
            this.clbToDoList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clbToDoList.ContextMenuStrip = this.cmsCheckBoxList;
            this.clbToDoList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbToDoList.FormattingEnabled = true;
            this.clbToDoList.Location = new System.Drawing.Point(12, 73);
            this.clbToDoList.Name = "clbToDoList";
            this.clbToDoList.Size = new System.Drawing.Size(349, 235);
            this.clbToDoList.TabIndex = 0;
            this.clbToDoList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbToDoList_ItemCheck);
            // 
            // cmsCheckBoxList
            // 
            this.cmsCheckBoxList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.cmsCheckBoxList.Name = "cmsCheckBoxList";
            this.cmsCheckBoxList.Size = new System.Drawing.Size(119, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // tbAddItems
            // 
            this.tbAddItems.Location = new System.Drawing.Point(12, 15);
            this.tbAddItems.Name = "tbAddItems";
            this.tbAddItems.Size = new System.Drawing.Size(349, 20);
            this.tbAddItems.TabIndex = 1;
            this.tbAddItems.Text = "Type & Enter to Add Tasks";
            this.tbAddItems.Enter += new System.EventHandler(this.tbAddItems_Enter);
            this.tbAddItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddItems_KeyPress);
            this.tbAddItems.Leave += new System.EventHandler(this.tbAddItems_Leave);
            // 
            // clbCompletedTasks
            // 
            this.clbCompletedTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clbCompletedTasks.ContextMenuStrip = this.cmsCheckBoxList;
            this.clbCompletedTasks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCompletedTasks.FormattingEnabled = true;
            this.clbCompletedTasks.Location = new System.Drawing.Point(12, 352);
            this.clbCompletedTasks.Name = "clbCompletedTasks";
            this.clbCompletedTasks.Size = new System.Drawing.Size(349, 151);
            this.clbCompletedTasks.TabIndex = 2;
            this.clbCompletedTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCompletedTasks_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasks To Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks Completed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(373, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbCompletedTasks);
            this.Controls.Add(this.tbAddItems);
            this.Controls.Add(this.clbToDoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.cmsCheckBoxList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbToDoList;
        private System.Windows.Forms.TextBox tbAddItems;
        private System.Windows.Forms.CheckedListBox clbCompletedTasks;
        private System.Windows.Forms.ContextMenuStrip cmsCheckBoxList;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}

