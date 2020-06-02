namespace Tund
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Банан");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Клубника");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Фрукты", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Кабачок");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Овощи", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Продукты", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "C#",
            "Python",
            "C++"});
            this.checkedListBox1.Location = new System.Drawing.Point(36, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(189, 72);
            this.checkedListBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Красный",
            "Желтый",
            "Синий",
            "Зеленый",
            "Розовый"});
            this.comboBox1.Location = new System.Drawing.Point(37, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(42, 195);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(192, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(40, 245);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел9";
            treeNode1.Text = "Банан";
            treeNode2.Name = "Узел10";
            treeNode2.Text = "Клубника";
            treeNode3.Name = "Узел8";
            treeNode3.Text = "Фрукты";
            treeNode4.Name = "Узел13";
            treeNode4.Text = "Кабачок";
            treeNode5.Name = "Узел12";
            treeNode5.Text = "Овощи";
            treeNode6.Name = "Узел3";
            treeNode6.Text = "Продукты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(193, 178);
            this.treeView1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(278, 28);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(484, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(278, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 59);
            this.progressBar1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(302, 203);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}