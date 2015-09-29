using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4CSharp
{
    public partial class Form2 : Form
    {
        const int R=25;
        Random random = new Random();
        static Form3 fig = new Form3();
        Graphics G = fig.CreateGraphics();

        public Form2()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fig.Show();

                if (CheckBox1.Checked == true)
                {
                    Font MyFont1 = new Font("Microsoft Sans Serif", 36);
                    G.DrawString("TEXT", MyFont1, Brushes.Blue, 370, 260);
                }

                if (CheckBox2.Checked == true)
                {
                    Pen MyPen1 = new Pen(Color.Red, 1);
                    Brush MyBrush1 = new SolidBrush(Color.Green);
                    G.DrawEllipse(MyPen1, 200, 140, 100, 100);
                    G.FillEllipse(MyBrush1, 201, 141, 99, 99);
                }

                if (CheckBox3.Checked == true)
                {
                    Font MyFont1 = new Font("Microsoft Sans Serif", 36);
                    G.DrawString("y=" + Function.Result(int.Parse(ListBox1.Text)), MyFont1, Brushes.Black, 20, 30);
                }

                if (CheckBox4.Checked == true)
                {
                    Pen MyPen1 = new Pen(Color.Black, 1);
                    Brush MyBrush1 = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Horizontal, Color.Red, Color.Empty);
                    Point[] points = { new Point(30, 250),
                                     new Point(60, 200),
                                     new Point(90, 250),
                                     new Point(60, 300)};
                                G.DrawPolygon(MyPen1, points);
                                G.FillPolygon(MyBrush1, points);
                }

                if (RadioButton1.Checked == true)
                {
                    Pen MyPen1 = new Pen(Color.Black, 1);
                    Brush MyBrush1 = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal, Color.Green, Color.Empty);
                    G.DrawRectangle(MyPen1, 370, 20, 100, 100);
                    G.FillRectangle(MyBrush1, 371, 21, 99, 99);
                }

                else if (RadioButton2.Checked == true)
                {
                    Pen MyPen1 = new Pen(Color.Black, 1);
                    Brush MyBrush1 = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Vertical, Color.Red, Color.Empty);
                    G.DrawEllipse(MyPen1, 370, 140, 140, 100);
                    G.FillEllipse(MyBrush1, 371, 141, 139, 99);
                }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListBox1.Text = "1";
        }

        public void draw(int curr, Point center, int level)
        {
        Point [] pts = new Point[7];
        Point [] tri = new Point[3];
        int i;
        for (i= 0; i<6; i++)
        {
            pts[i].X = center.X + Convert.ToInt32(R * Math.Cos(((60 * i - 1 + 90) % 360) * 3.14 / 180));
            pts[i].Y = center.Y - Convert.ToInt32(R * Math.Sin(((60 * i - 1+ 90) % 360) * 3.14 / 180));
        }
        pts[6]= pts[0];
        
        for (i= 0; i<6; i++)
        {
            Color c1 = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            Color c2 = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            tri[0] = center;
            tri[1] = pts[i];
            tri[2] = pts[i+1];
            Brush MyBrush1 = new SolidBrush(c1);
            Pen MyPen = new Pen(c2, 2);
            G.FillPolygon(MyBrush1, tri);
            G.DrawPolygon(MyPen, tri);
        }
        for (i = curr; i< 7; i++)
        if ((pts[i].X >= 0 && pts[i].X < fig.Width) && (pts[i].Y >= 0 && pts[i].Y < fig.Height) && level < 6)
        {
            draw(i, pts[i], level+1);
        }
        Thread.Sleep(5);
        Application.DoEvents();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            fig.Show();
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            Font MyFont1 = new Font("Microsoft Sans Serif", 14);
            G.DrawString("Kaleidoscope mode", MyFont1, Brushes.Aqua, 0, 0);
            Point p = new Point();
            p.X = fig.Width / 2;
            p.Y = (fig.Height - 50) / 2;
            draw(1, p, 0);
        }
    }
}
