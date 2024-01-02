using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLTTQTH
{
    public partial class muaVe : Form
    {
        public double UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public muaVe()
        {
            InitializeComponent();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            Quantity = Convert.ToInt32(txtQuantity.Text);

            // Đóng Form2 với DialogResult là OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
