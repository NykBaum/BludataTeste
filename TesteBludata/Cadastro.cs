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
    public partial class Cadastro : Form
    {
        public string estado;
        public Form1 form;
        public TesteBludata.BD_BLUDATA DB = new TesteBludata.BD_BLUDATA();
        public int idPessoa = -1;
        private List<Telefone> telefones = new List<Telefone>();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            if (form.estado.Equals("PR")) 
                dtpDataNasc.MaxDate = DateTime.Now.Date.AddYears(-18);
            else
                dtpDataNasc.MaxDate = DateTime.Now.Date;

            if (idPessoa > -1)
            { 
                Pessoa pessoa = DB.Pessoa.Where(a => a.id == idPessoa).First();
                
                dtpDataNasc.Value = pessoa.data_nasc;
                txtCPF.Text = pessoa.cpf;
                txtNome.Text = pessoa.nome;
                txtRG.Text = pessoa.rg;
            }
            
            telefones =  DB.Telefone.Where(a => a.id_pessoa == idPessoa).ToList();
            recarregaTelefones();
        }

        private void recarregaTelefones()
        {
            dgvTelefones.DataSource = telefones.Select( a => new {a.num_tel}).ToList();
            dgvTelefones.Refresh();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now.Date;
            DateTime datNasc = dtpDataNasc.Value.Date;

            if (estado.Equals("SC") && txtRG.Text == "")
            {
                MessageBox.Show("O RG deve ser preenchido!");
                return;
            }else if (estado.Equals("PR") && agora.Subtract(datNasc).TotalDays < (18*365))
            {
                MessageBox.Show("Somente pessoas com mais de 18 anos podem ser cadastradas!");
                return;
            }

            if (idPessoa > 0)
            {
                DB.Pessoa.Find(idPessoa).nome = txtNome.Text;
                DB.Pessoa.Find(idPessoa).cpf = txtCPF.Text;
                DB.Pessoa.Find(idPessoa).rg = txtRG.Text;
                DB.Pessoa.Find(idPessoa).data_nasc = dtpDataNasc.Value.Date;
            }
            else
            {
                Pessoa pessoa = new Pessoa();
                pessoa.cpf = txtCPF.Text;
                pessoa.data_nasc = dtpDataNasc.Value.Date;
                pessoa.nome = txtNome.Text;
                pessoa.data_cad = DateTime.Now;
                pessoa.rg = txtRG.Text;
                DB.Pessoa.Add(pessoa);
                DB.SaveChanges();
                idPessoa = DB.Pessoa.Max(a => a.id);
            }

            DB.Telefone.RemoveRange(DB.Telefone.Where(a => a.id_pessoa == idPessoa).ToList());

            foreach (Telefone tel in telefones)
            {
                Telefone tele = new Telefone();
                tele.id_pessoa = idPessoa;
                tele.num_tel = tel.num_tel;
                tele.Pessoa = DB.Pessoa.Find(idPessoa);
                DB.Telefone.Add(tele);
            }

            DB.SaveChanges();

            form.limpaFiltro();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefone tel = new Telefone();
            tel.num_tel = txtTelefone.Text;
            tel.id_pessoa = idPessoa;

            telefones.Add(tel);

            recarregaTelefones();

            txtTelefone.Text = "";
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
