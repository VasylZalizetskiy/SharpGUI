using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4CSharp
{
    public partial class Form1 : Form
    {
        Form2 dlg = new Form2();
        Form4 edit = new Form4();
        int x;
        double y;
        string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            str = Function.InputBox("Input x", "InputBox");
            if (str != "")
            {
                x = int.Parse(str);
                y = Function.Result(x);
            }
            else
                MessageBox.Show("x is unknown", "Result y=", MessageBoxButtons.OK);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            dlg.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            MessageBox.Show("y=" + y, "Result", MessageBoxButtons.OK);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Базові елементи інтерфейсу в c#", "About", MessageBoxButtons.OK);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
            String FileName = OpenFileDialog1.FileName;
            if (System.IO.File.Exists(FileName))
            {
                System.IO.StreamReader Read = new System.IO.StreamReader(FileName);
                edit.textBox1.Text = Read.ReadToEnd();
                Read.Close();
                edit.Show();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            edit.textBox1.Text = "";
        }

        private void Reneme_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.ShowDialog();
            String FileName = SaveFileDialog1.FileName;
            if (FileName != "")
            {
                System.IO.StreamWriter Write = new System.IO.StreamWriter(FileName);
                Write.Write(edit.textBox1.Text);
                Write.Close();
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by ZVV", "About", MessageBoxButtons.OK);
        }

        private void AddWindow_Click(object sender, EventArgs e)
        {
            Form ChildWindow = new Form();
            ChildWindow.MdiParent = this;
            ChildWindow.Show();
            ChildWindow.Text = "MdiChildren";
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length > 0)
                MdiChildren.Last().Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
        }
    }
}
