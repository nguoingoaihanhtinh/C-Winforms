namespace Paint
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
            panel1 = new Panel();
            color_pick = new PictureBox();
            pic_color = new Button();
            panel3 = new Panel();
            btn_Gradient = new Button();
            btn_Bazier = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_Clear = new Button();
            btn_Line = new Button();
            btn_Color = new Button();
            btn_Fill = new Button();
            btn_Pencil = new Button();
            btn_Eraser = new Button();
            btn_Rectangle = new Button();
            btn_Eclipse = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_pick).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(color_pick);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 100);
            panel1.TabIndex = 0;
            // 
            // color_pick
            // 
            color_pick.Cursor = Cursors.Hand;
            color_pick.Image = Properties.Resources.color_palette;
            color_pick.Location = new Point(3, 3);
            color_pick.Name = "color_pick";
            color_pick.Size = new Size(274, 97);
            color_pick.SizeMode = PictureBoxSizeMode.StretchImage;
            color_pick.TabIndex = 10;
            color_pick.TabStop = false;
            color_pick.Paint += color_pick_Paint;
            color_pick.MouseClick += color_pick_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = SystemColors.ButtonHighlight;
            pic_color.Location = new Point(283, 35);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(48, 34);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(btn_Gradient);
            panel3.Controls.Add(btn_Bazier);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btn_Clear);
            panel3.Controls.Add(btn_Line);
            panel3.Controls.Add(btn_Color);
            panel3.Controls.Add(btn_Fill);
            panel3.Controls.Add(btn_Pencil);
            panel3.Controls.Add(btn_Eraser);
            panel3.Controls.Add(btn_Rectangle);
            panel3.Controls.Add(btn_Eclipse);
            panel3.Location = new Point(337, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(647, 100);
            panel3.TabIndex = 9;
            // 
            // btn_Gradient
            // 
            btn_Gradient.Cursor = Cursors.Hand;
            btn_Gradient.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Gradient.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Gradient.FlatStyle = FlatStyle.Flat;
            btn_Gradient.ForeColor = SystemColors.ButtonFace;
            btn_Gradient.ImageAlign = ContentAlignment.BottomCenter;
            btn_Gradient.Location = new Point(79, 50);
            btn_Gradient.Name = "btn_Gradient";
            btn_Gradient.RightToLeft = RightToLeft.No;
            btn_Gradient.Size = new Size(45, 31);
            btn_Gradient.TabIndex = 12;
            btn_Gradient.Text = "Gradient";
            btn_Gradient.UseVisualStyleBackColor = true;
            btn_Gradient.Click += btn_Gradient_Click;
            // 
            // btn_Bazier
            // 
            btn_Bazier.Cursor = Cursors.Hand;
            btn_Bazier.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Bazier.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Bazier.FlatStyle = FlatStyle.Flat;
            btn_Bazier.ForeColor = SystemColors.ButtonFace;
            btn_Bazier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Bazier.Location = new Point(305, 45);
            btn_Bazier.Name = "btn_Bazier";
            btn_Bazier.Size = new Size(48, 30);
            btn_Bazier.TabIndex = 11;
            btn_Bazier.Text = "Bazier";
            btn_Bazier.TextAlign = ContentAlignment.BottomCenter;
            btn_Bazier.UseVisualStyleBackColor = true;
            btn_Bazier.Click += btn_Bazier_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            button2.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(251, 45);
            button2.Name = "button2";
            button2.Size = new Size(48, 30);
            button2.TabIndex = 10;
            button2.Text = "Arc";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            button1.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Highlight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(548, 20);
            button1.Name = "button1";
            button1.Size = new Size(67, 27);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.AntiqueWhite;
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Clear.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.ForeColor = SystemColors.Highlight;
            btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clear.Location = new Point(548, 53);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(67, 27);
            btn_Clear.TabIndex = 5;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Line
            // 
            btn_Line.Cursor = Cursors.Hand;
            btn_Line.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Line.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Line.FlatStyle = FlatStyle.Flat;
            btn_Line.ForeColor = SystemColors.ButtonFace;
            btn_Line.Image = Properties.Resources.line;
            btn_Line.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Line.Location = new Point(334, 9);
            btn_Line.Name = "btn_Line";
            btn_Line.Size = new Size(48, 30);
            btn_Line.TabIndex = 7;
            btn_Line.TextAlign = ContentAlignment.BottomCenter;
            btn_Line.UseVisualStyleBackColor = true;
            btn_Line.Click += btn_Line_Click;
            // 
            // btn_Color
            // 
            btn_Color.Cursor = Cursors.Hand;
            btn_Color.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Color.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Color.FlatStyle = FlatStyle.Flat;
            btn_Color.ForeColor = SystemColors.ButtonHighlight;
            btn_Color.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Color.Location = new Point(14, 9);
            btn_Color.Name = "btn_Color";
            btn_Color.Size = new Size(46, 30);
            btn_Color.TabIndex = 1;
            btn_Color.Text = "Color";
            btn_Color.UseVisualStyleBackColor = true;
            btn_Color.Click += btn_Color_Click;
            // 
            // btn_Fill
            // 
            btn_Fill.Cursor = Cursors.Hand;
            btn_Fill.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Fill.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Fill.FlatStyle = FlatStyle.Flat;
            btn_Fill.ForeColor = SystemColors.ButtonFace;
            btn_Fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Fill.Location = new Point(79, 9);
            btn_Fill.Name = "btn_Fill";
            btn_Fill.Size = new Size(45, 30);
            btn_Fill.TabIndex = 2;
            btn_Fill.Text = "Fill";
            btn_Fill.UseVisualStyleBackColor = true;
            btn_Fill.Click += btn_Fill_Click;
            // 
            // btn_Pencil
            // 
            btn_Pencil.Cursor = Cursors.Hand;
            btn_Pencil.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Pencil.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Pencil.FlatStyle = FlatStyle.Flat;
            btn_Pencil.ForeColor = SystemColors.ButtonFace;
            btn_Pencil.ImageAlign = ContentAlignment.BottomLeft;
            btn_Pencil.Location = new Point(139, 22);
            btn_Pencil.Name = "btn_Pencil";
            btn_Pencil.Size = new Size(51, 31);
            btn_Pencil.TabIndex = 3;
            btn_Pencil.Text = "Pencil";
            btn_Pencil.UseVisualStyleBackColor = true;
            btn_Pencil.Click += btn_Pencil_Click;
            // 
            // btn_Eraser
            // 
            btn_Eraser.Cursor = Cursors.Hand;
            btn_Eraser.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Eraser.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Eraser.FlatStyle = FlatStyle.Flat;
            btn_Eraser.ForeColor = SystemColors.ButtonFace;
            btn_Eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eraser.Location = new Point(15, 51);
            btn_Eraser.Name = "btn_Eraser";
            btn_Eraser.Size = new Size(45, 30);
            btn_Eraser.TabIndex = 4;
            btn_Eraser.Text = "Eraser";
            btn_Eraser.UseVisualStyleBackColor = true;
            btn_Eraser.Click += btn_Eraser_Click;
            // 
            // btn_Rectangle
            // 
            btn_Rectangle.Cursor = Cursors.Hand;
            btn_Rectangle.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Rectangle.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Rectangle.FlatStyle = FlatStyle.Flat;
            btn_Rectangle.ForeColor = SystemColors.ButtonFace;
            btn_Rectangle.Image = Properties.Resources.rectangle;
            btn_Rectangle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Rectangle.Location = new Point(280, 9);
            btn_Rectangle.Name = "btn_Rectangle";
            btn_Rectangle.Size = new Size(48, 30);
            btn_Rectangle.TabIndex = 6;
            btn_Rectangle.TextAlign = ContentAlignment.BottomCenter;
            btn_Rectangle.UseVisualStyleBackColor = true;
            btn_Rectangle.Click += btn_Rectangle_Click;
            // 
            // btn_Eclipse
            // 
            btn_Eclipse.Cursor = Cursors.Hand;
            btn_Eclipse.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            btn_Eclipse.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            btn_Eclipse.FlatStyle = FlatStyle.Flat;
            btn_Eclipse.ForeColor = SystemColors.ButtonFace;
            btn_Eclipse.Image = Properties.Resources.circle;
            btn_Eclipse.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eclipse.Location = new Point(226, 9);
            btn_Eclipse.Name = "btn_Eclipse";
            btn_Eclipse.Size = new Size(48, 30);
            btn_Eclipse.TabIndex = 5;
            btn_Eclipse.TextAlign = ContentAlignment.BottomCenter;
            btn_Eclipse.UseVisualStyleBackColor = true;
            btn_Eclipse.Click += btn_Eclipse_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 100);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 100);
            pic.Name = "pic";
            pic.Size = new Size(984, 411);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(pic);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_pick).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_Color;
        private Button btn_Eraser;
        private Button btn_Pencil;
        private Button btn_Fill;
        private Button btn_Line;
        private Button btn_Rectangle;
        private Button btn_Eclipse;
        private Panel panel3;
        private PictureBox color_pick;
        private Button btn_Clear;
        private Button button1;
        private Button button2;
        private Button btn_Bazier;
        private Button btn_Gradient;
    }
}