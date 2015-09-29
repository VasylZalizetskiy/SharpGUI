namespace Lab4CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 231);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip1.Size = new System.Drawing.Size(399, 22);
            this.StatusStrip1.TabIndex = 6;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.DialogToolStripMenuItem,
            this.InfoToolStripMenuItem,
            this.AddWindowToolStripMenuItem,
            this.CloseWindowToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.ToolStripMenuItem1});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(399, 24);
            this.MenuStrip1.TabIndex = 8;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.RenameToolStripMenuItem});
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ФайлToolStripMenuItem.Text = "&Calc";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "&Input";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.Input_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "&Run";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.Run_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RenameToolStripMenuItem.Text = "&Result";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.Result_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.PrintToolStripMenuItem.Text = "&About";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // DialogToolStripMenuItem
            // 
            this.DialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem1,
            this.DeleteToolStripMenuItem,
            this.RenemeToolStripMenuItem});
            this.DialogToolStripMenuItem.Name = "DialogToolStripMenuItem";
            this.DialogToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.DialogToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem1
            // 
            this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
            this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem1.Text = "&Open";
            this.OpenToolStripMenuItem1.Click += new System.EventHandler(this.Open_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteToolStripMenuItem.Text = "&Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RenemeToolStripMenuItem
            // 
            this.RenemeToolStripMenuItem.Name = "RenemeToolStripMenuItem";
            this.RenemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RenemeToolStripMenuItem.Text = "&Rename";
            this.RenemeToolStripMenuItem.Click += new System.EventHandler(this.Reneme_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.InfoToolStripMenuItem.Text = "I&nfo";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.Info_Click);
            // 
            // AddWindowToolStripMenuItem
            // 
            this.AddWindowToolStripMenuItem.Name = "AddWindowToolStripMenuItem";
            this.AddWindowToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.AddWindowToolStripMenuItem.Text = "&Add window";
            this.AddWindowToolStripMenuItem.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // CloseWindowToolStripMenuItem
            // 
            this.CloseWindowToolStripMenuItem.Name = "CloseWindowToolStripMenuItem";
            this.CloseWindowToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.CloseWindowToolStripMenuItem.Text = "&Close window";
            this.CloseWindowToolStripMenuItem.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ExitToolStripMenuItem.Text = "&Quit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2,
            this.ToolStripButton3,
            this.ToolStripSeparator1,
            this.ToolStripButton4,
            this.ToolStripButton5,
            this.ToolStripButton6,
            this.ToolStripSeparator2,
            this.ToolStripButton7,
            this.ToolStripButton8,
            this.ToolStripSeparator3,
            this.ToolStripButton9,
            this.ToolStripButton10,
            this.ToolStripButton11});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(399, 25);
            this.ToolStrip1.TabIndex = 9;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton1.Text = "ToolStripButton1";
            this.ToolStripButton1.Click += new System.EventHandler(this.Input_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton2.Text = "ToolStripButton2";
            this.ToolStripButton2.Click += new System.EventHandler(this.Run_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton3.Text = "ToolStripButton3";
            this.ToolStripButton3.Click += new System.EventHandler(this.Result_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton4.Text = "ToolStripButton4";
            this.ToolStripButton4.Click += new System.EventHandler(this.About_Click);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton5.Image")));
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton5.Text = "ToolStripButton5";
            this.ToolStripButton5.Click += new System.EventHandler(this.Open_Click);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton6.Image")));
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton6.Text = "ToolStripButton6";
            this.ToolStripButton6.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton7
            // 
            this.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton7.Image")));
            this.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton7.Text = "ToolStripButton7";
            this.ToolStripButton7.Click += new System.EventHandler(this.Reneme_Click);
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton8.Image")));
            this.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton8.Text = "ToolStripButton8";
            this.ToolStripButton8.Click += new System.EventHandler(this.Info_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton9
            // 
            this.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton9.Image")));
            this.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton9.Name = "ToolStripButton9";
            this.ToolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton9.Text = "ToolStripButton9";
            this.ToolStripButton9.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // ToolStripButton10
            // 
            this.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton10.Image")));
            this.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton10.Name = "ToolStripButton10";
            this.ToolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton10.Text = "ToolStripButton10";
            this.ToolStripButton10.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton11.Image")));
            this.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton11.Text = "ToolStripButton11";
            this.ToolStripButton11.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DialogToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RenemeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddWindowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseWindowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton7;
        internal System.Windows.Forms.ToolStripButton ToolStripButton8;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton9;
        internal System.Windows.Forms.ToolStripButton ToolStripButton10;
        internal System.Windows.Forms.ToolStripButton ToolStripButton11;
    }
}

