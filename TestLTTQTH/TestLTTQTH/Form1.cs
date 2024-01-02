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
    public partial class Form1 : Form
    {
      
        private List<ListViewItem> ticketList = new List<ListViewItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string address = txtAddress.Text;
            string profession = rbtnStudent.Checked ? "Sinh viên" : "Khác";
            
            using (muaVe muaVe = new muaVe())
            {
                if(muaVe.ShowDialog() == DialogResult.OK)
                {
                    int quantity = muaVe.Quantity;
                    double unitPrice = muaVe.UnitPrice;

                    double totalAmount = quantity * unitPrice;
                    double vat = 0.1 * totalAmount;
                    double discount = profession == "Sinh viên" ? 0.1 * totalAmount : 0.05 * totalAmount;
                    double totalPrice = totalAmount + vat - discount;

                    ListViewItem item = new ListViewItem(new[]
                    {
                        customerName,
                        address,
                        profession,
                        quantity.ToString(),
                        unitPrice.ToString("C"),
                        totalAmount.ToString("C"),
                        vat.ToString("C"),
                        discount.ToString("C"),
                        totalPrice.ToString("C")
                    });

                    ticketList.Add(item);

                    // Hiển thị kết quả ở đây hoặc thực hiện các công việc khác
                    UpdateListView();
                }
                else
                {
                    return;
                }
            }
        }
        private void UpdateListView()
        {
            // Xóa tất cả các item hiện tại trong ListView
            listViewTickets.Items.Clear();

            // Thêm các item mới vào ListView
            listViewTickets.Items.AddRange(ticketList.ToArray());
        }
    }
}
