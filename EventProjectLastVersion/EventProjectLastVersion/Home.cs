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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void rervBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            Reservations re = new Reservations();
            re.ShowDialog();
        }

        private void makeBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            MakeResrvation mr = new MakeResrvation();
            mr.ShowDialog();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            Search sc = new Search();
            sc.ShowDialog();
        }

        private void summBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            Summary sm = new Summary();
            sm.ShowDialog();
        }

        private void chBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            addNew an = new addNew();
            an.ShowDialog();
        }

        private void cmBtn_Click(object sender, EventArgs e)
        {
            // open a new form
            compenies cm = new compenies();
            cm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
