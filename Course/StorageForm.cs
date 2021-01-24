using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course
{
    public partial class StorageForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlCommandBuilder sqlBuilder1 = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlDataAdapter sqlDataAdapter1 = null;
        private DataSet dataSet = null;
        private DataSet dataSet1 = null;

        public StorageForm()
        {

            InitializeComponent();

        }

        private void StorageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void receipt_MenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Show();
        }

        private void writeOff_MenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteOffForm writeOffForm = new WriteOffForm();
            writeOffForm.Show();
        }

        private void inventory_MenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }
        private void StorageForm_Load(object sender, EventArgs e)
        {

        }
        private void fabricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablePrintForm tpf = new TablePrintForm(this, dataSet, "Cloths");
            tpf.Show();
        }

        private void fittingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablePrintForm tpf = new TablePrintForm(this, dataSet1, "Fittings");
            tpf.Show();
        }
    }
}
