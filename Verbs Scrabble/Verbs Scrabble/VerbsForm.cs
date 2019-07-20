using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verbs_Scrabble
{
    public partial class VerbsForm : UserControl
    {
        public VerbsForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtVerb.Text == "")
            {
                MessageBox.Show("El campo esta vacio", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVerb.Focus();
            }
        }
    }
}
