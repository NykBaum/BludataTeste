using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBludata
{
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }

        private void Estado_Load(object sender, EventArgs e)
        {
            cmbEstado.DataSource = new ArrayList() {"SC","PR"};
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\config.ini", true))
            {
                writer.WriteLine(cmbEstado.Text);
            }
            this.Close();
        }
    }
}
