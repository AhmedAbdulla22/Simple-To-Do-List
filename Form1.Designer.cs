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
            this.clbToDoList = new System.Windows.Forms.CheckedListBox();
            this.tbAddItems = new System.Windows.Forms.TextBox();
            this.clbCompletedTasks = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbToDoList
            // 
            this.clbToDoList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbToDoList.FormattingEnabled = true;
            this.clbToDoList.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.clbToDoList.Location = new System.Drawing.Point(12, 84);
            this.clbToDoList.Name = "clbToDoList";
            this.clbToDoList.Size = new System.Drawing.Size(349, 235);
            this.clbToDoList.TabIndex = 0;
            this.clbToDoList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbToDoList_ItemCheck);
            // 
            // tbAddItems
            // 
            this.tbAddItems.Location = new System.Drawing.Point(12, 58);
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
            this.clbCompletedTasks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCompletedTasks.FormattingEnabled = true;
            this.clbCompletedTasks.Location = new System.Drawing.Point(12, 325);
            this.clbCompletedTasks.Name = "clbCompletedTasks";
            this.clbCompletedTasks.Size = new System.Drawing.Size(349, 109);
            this.clbCompletedTasks.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 524);
            this.Controls.Add(this.clbCompletedTasks);
            this.Controls.Add(this.tbAddItems);
            this.Controls.Add(this.clbToDoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbToDoList;
        private System.Windows.Forms.TextBox tbAddItems;
        private System.Windows.Forms.CheckedListBox clbCompletedTasks;
    }
}

