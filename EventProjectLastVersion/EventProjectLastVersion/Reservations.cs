using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProjectLastVersion
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDataSet);

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDataSet.patient);

        }

        private void rervBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
