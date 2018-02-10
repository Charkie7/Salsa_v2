using System;
using System.Windows.Forms;

namespace Salsa_v2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn frm = new LogIn(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void clientAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAccount frm = new ClientAccount(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments frm = new Payments(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounts frm = new Accounts(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void ticketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticketing frm = new Ticketing(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search frm = new Search(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClient frm = new NewClient(); // makes a new login form
            frm.MdiParent = this;    // makes this the parent to all other forms
            frm.Show();             // show the new form
        }
    }
}
