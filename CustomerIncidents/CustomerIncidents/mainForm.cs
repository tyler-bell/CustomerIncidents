using System;
using System.Windows.Forms;

namespace CustomerIncidents {
    public partial class mainForm : Form {
        public mainForm() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {

        }

        private void getCustomerToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.customersTableAdapter.GetCustomer(this.techSupportDataSet.Customers, ((int)(System.Convert.ChangeType(custIDToolStripTextBox.Text, typeof(int)))));
                this.incidentsTableAdapter.FillBy(this.techSupportDataSet.Incidents, ((int)(System.Convert.ChangeType(custIDToolStripTextBox.Text, typeof(int)))));
                if (String.IsNullOrEmpty(customerIDTextBox.Text)) {
                    MessageBox.Show("Customer ID not found.");

                }
            } catch (System.Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
