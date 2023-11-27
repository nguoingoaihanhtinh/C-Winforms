namespace String_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Lấy kích thước của form
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Xác định cạnh của hình vuông
            int squareSize = Math.Min(formWidth, formHeight);

            // Tạo một mảng chứa 4 tên
            string[] names = { "Phan", "Tuấn", "Anh", "Khoa" };

            // Tạo một font cho văn bản
            Font font = new Font("Arial", 12);

            // Vẽ các chuỗi lần lượt theo chiều kim đồng hồ
            for (int i = 0; i < names.Length; i++)
            {
                // Tính toán vị trí và kích thước cho văn bản
                float angle = (float)(i * Math.PI / 2); // Góc trong radian
                float x = formWidth / 2 + (float)(Math.Cos(angle) * squareSize / 3);
                float y = formHeight / 2 + (float)(Math.Sin(angle) * squareSize / 3);

                // Lấy kích thước của chuỗi
                SizeF textSize = e.Graphics.MeasureString(names[i], font);

                // Vẽ chuỗi vào vị trí đã tính toán
                e.Graphics.DrawString(names[i], font, Brushes.Black, x - textSize.Width / 2, y - textSize.Height / 2);
            }
        }
    }
}