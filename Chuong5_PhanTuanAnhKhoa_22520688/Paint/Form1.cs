using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            //MouseClick += pic_MouseClick;
            //Paint += pic_Paint;
        }


        private Point startPoint;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        Brush brush = new SolidBrush(Color.Black);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_Color;

        private float stA = 45.0f;
        private float swA = 90.0f;

        private Point[] beziers = new Point[4];

        private int clickcount = 0;


        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X; cY = e.Y;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X; y = e.Y;
            sX = e.X - cX; sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX; sY = y - cY;
            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 8)
            {
                Rectangle arcBounds = new Rectangle(
                    Math.Min(px.X, py.X),
                    Math.Min(px.Y, py.Y),
                    Math.Abs(px.X - py.X),
                    Math.Abs(px.Y - py.Y));
                int startangle = (int)(Math.Atan2(px.Y - arcBounds.Y - arcBounds.Height / 2, px.X - arcBounds.X - arcBounds.Width / 2) * 180 / Math.PI);
                int endangle = (int)(Math.Atan2(py.Y - arcBounds.Y - arcBounds.Height / 2, py.X - arcBounds.X - arcBounds.Width / 2) * 180 / Math.PI);
                g.DrawArc(Pens.Black, arcBounds, startangle, endangle - startangle);
            }
            if (index == 9)
            {
                if (clickcount == 4)
                {
                    g.DrawBezier(p, beziers[0], beziers[1], beziers[2], beziers[3]);
                }
                foreach (Point point in beziers)
                {
                    g.FillEllipse(brush, point.X - 5, point.Y - 5, 10, 10);
                }

            }


        }

        private void btn_Pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_Eclipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void color_pick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                if (index == 8)
                {
                    Rectangle arcBounds = new Rectangle(
                        Math.Min(px.X, py.X),
                        Math.Min(px.Y, py.Y),
                        Math.Abs(px.X - py.X),
                        Math.Abs(px.Y - py.Y));
                    int startangle = (int)(Math.Atan2(px.Y - arcBounds.Y - arcBounds.Height / 2, px.X - arcBounds.X - arcBounds.Width / 2) * 180 / Math.PI);
                    int endangle = (int)(Math.Atan2(py.Y - arcBounds.Y - arcBounds.Height / 2, py.X - arcBounds.X - arcBounds.Width / 2) * 180 / Math.PI);
                    g.DrawArc(Pens.Black, arcBounds, startangle, endangle - startangle);
                }
                if (index == 9)
                {
                    if (clickcount == 4)
                    {
                        g.DrawBezier(p, beziers[0], beziers[1], beziers[2], beziers[3]);
                    }
                    foreach (Point point in beziers)
                    {
                        g.FillEllipse(brush, point.X - 5, point.Y - 5, 10, 10);
                    }

                }

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;

        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_Color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_Point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_pick_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_Point(color_pick, e.Location);
            pic_color.BackColor = ((Bitmap)color_pick.Image).GetPixel(point.X, point.Y);
            new_Color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_Color, Color new_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_Color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_Color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_Color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_Color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_Color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_Color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_Point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_Color);
            }
            if (index == 9)
            {
                if (clickcount < 4)
                {
                    beziers[clickcount] = new Point(e.X, e.Y);
                    clickcount++;
                    Invalidate();
                }
            }
            if (index == 10)
            {
                Point point = set_Point(pic, e.Location);
                LinearGradientBrush br = new LinearGradientBrush(px, py, Color.Red, Color.Blue);
                g.FillEllipse(br, cX, cY, sX, sY);
            }

        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("image saved!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void btn_Bazier_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void btn_Gradient_Click(object sender, EventArgs e)
        {
            index = 10;
        }
    }
}