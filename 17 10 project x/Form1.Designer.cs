
namespace _17_10_project_x
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЦветаИРадиусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.радиусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборАлгоритмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмДжарвисаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(879, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.выборЦветаИРадиусаToolStripMenuItem,
            this.выборАлгоритмаToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(879, 24);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem1.Text = "Выбор фигуры";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem3.Text = "Круг";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.toolStripMenuItem3_CheckedChanged);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem4.Text = "Квадрат";
            this.toolStripMenuItem4.CheckedChanged += new System.EventHandler(this.toolStripMenuItem4_CheckedChanged);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem5.Text = "Треугольник";
            this.toolStripMenuItem5.CheckedChanged += new System.EventHandler(this.toolStripMenuItem5_CheckedChanged);
            // 
            // выборЦветаИРадиусаToolStripMenuItem
            // 
            this.выборЦветаИРадиусаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem1,
            this.радиусToolStripMenuItem});
            this.выборЦветаИРадиусаToolStripMenuItem.Name = "выборЦветаИРадиусаToolStripMenuItem";
            this.выборЦветаИРадиусаToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.выборЦветаИРадиусаToolStripMenuItem.Text = "Выбор цвета и радиуса";
            // 
            // цветToolStripMenuItem1
            // 
            this.цветToolStripMenuItem1.Name = "цветToolStripMenuItem1";
            this.цветToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.цветToolStripMenuItem1.Text = "Цвет";
            this.цветToolStripMenuItem1.Click += new System.EventHandler(this.цветToolStripMenuItem1_Click);
            // 
            // радиусToolStripMenuItem
            // 
            this.радиусToolStripMenuItem.Name = "радиусToolStripMenuItem";
            this.радиусToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.радиусToolStripMenuItem.Text = "Радиус";
            this.радиусToolStripMenuItem.Click += new System.EventHandler(this.радиусToolStripMenuItem_Click);
            // 
            // выборАлгоритмаToolStripMenuItem
            // 
            this.выборАлгоритмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгоритмДжарвисаToolStripMenuItem1});
            this.выборАлгоритмаToolStripMenuItem.Name = "выборАлгоритмаToolStripMenuItem";
            this.выборАлгоритмаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.выборАлгоритмаToolStripMenuItem.Text = "Выбор алгоритма";
            // 
            // алгоритмДжарвисаToolStripMenuItem1
            // 
            this.алгоритмДжарвисаToolStripMenuItem1.Checked = true;
            this.алгоритмДжарвисаToolStripMenuItem1.CheckOnClick = true;
            this.алгоритмДжарвисаToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.алгоритмДжарвисаToolStripMenuItem1.Name = "алгоритмДжарвисаToolStripMenuItem1";
            this.алгоритмДжарвисаToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.алгоритмДжарвисаToolStripMenuItem1.Text = "Алгоритм Джарвиса?";
            this.алгоритмДжарвисаToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.алгоритмДжарвисаToolStripMenuItem1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 456);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаИРадиусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выборАлгоритмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмДжарвисаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem радиусToolStripMenuItem;
    }
}

