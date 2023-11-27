using System.Drawing;
using System.Windows.Forms;

namespace Font_List
{
    public partial class Form1 : Form
    {
        private Label sampleTextLabel;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            sampleTextLabel = new Label();
            sampleTextLabel.AutoSize = true;
            Controls.Add(sampleTextLabel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fontNames = FontFamily.Families.Select(f => f.Name).ToArray();

            // Tạo và cấu hình ListView để hiển thị danh sách font
            ListView fontListView = new ListView();
            fontListView.Dock = DockStyle.Left;
            fontListView.Width = 200;
            fontListView.View = View.Details;
            fontListView.Columns.Add("Font", 200);

            // Thêm mỗi font vào ListView
            foreach (var fontName in fontNames)
            {
                ListViewItem item = new ListViewItem(fontName);
                fontListView.Items.Add(item);
            }

            // Thêm sự kiện để vẽ một mẫu văn bản cho mỗi font khi chọn font
            fontListView.SelectedIndexChanged += FontListView_SelectedIndexChanged;

            // Thêm ListView vào Form
            Controls.Add(fontListView);
        }




        private void FontListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListView fontListView && fontListView.SelectedItems.Count > 0)
            {
                // Lấy font được chọn
                string selectedFontName = fontListView.SelectedItems[0].Text;
                Font selectedFont = new Font(selectedFontName, 12); // 12 là kích thước font

                // Hiển thị mẫu văn bản bằng font được chọn
                sampleTextLabel.Text = "Hello, Font!";
                sampleTextLabel.Font = selectedFont;
            }
        }
    }

}