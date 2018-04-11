using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBludata
{
    public partial class Filtrar : Form
    {
        public Form1 form;
        public Filtrar()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            form.fil_nome = txtNome.Text;

            if (dtpCadastroIni.Checked)
                form.fil_dat_cad_ini = dtpCadastroIni.Value.Date;
            else
                form.fil_dat_cad_ini = DateTime.MinValue;

            if (dtpCadastroFim.Checked)
                form.fil_dat_cad_fim = dtpCadastroFim.Value.Date;
            else
                form.fil_dat_cad_fim = DateTime.MaxValue;

            if (dtpDataNascIni.Checked)
                form.fil_dat_nasc_ini = dtpDataNascIni.Value.Date;
            else
                form.fil_dat_nasc_ini = DateTime.MinValue;

            if (dtpDataNascFim.Checked)
                form.fil_dat_nasc_fim = dtpDataNascFim.Value.Date;
            else
                form.fil_dat_nasc_fim = DateTime.MaxValue;

            form.reloadGrid();
            this.Close();
        }

        private void Filtrar_Load(object sender, EventArgs e)
        {
            txtNome.Text = form.fil_nome;

            if (form.fil_dat_cad_ini == DateTime.MinValue)
                dtpCadastroIni.Checked = false;
            else
                dtpCadastroIni.Value = form.fil_dat_cad_ini;

            if (form.fil_dat_cad_fim == DateTime.MaxValue)
                dtpCadastroFim.Checked = false;
            else
                dtpCadastroFim.Value = form.fil_dat_cad_fim;

            if (form.fil_dat_nasc_ini == DateTime.MinValue)
                dtpDataNascIni.Checked = false;
            else
                dtpDataNascIni.Value = form.fil_dat_nasc_ini;

            if (form.fil_dat_nasc_fim == DateTime.MaxValue)
                dtpDataNascFim.Checked = false;
            else
                dtpDataNascFim.Value = form.fil_dat_nasc_fim;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
