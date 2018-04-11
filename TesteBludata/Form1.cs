using System;
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
    public partial class Form1 : Form
    {
        public string estado = "";

        public string fil_nome = "";
        public string fil_cpf  = "";
        public string fil_rg   = "";
        public DateTime fil_dat_nasc_ini = DateTime.MinValue;
        public DateTime fil_dat_cad_ini  = DateTime.MinValue;
        public DateTime fil_dat_nasc_fim = DateTime.MaxValue;
        public DateTime fil_dat_cad_fim = DateTime.MaxValue;

        TesteBludata.BD_BLUDATA DB = new TesteBludata.BD_BLUDATA();

        public Form1()
        {
            InitializeComponent();
        }
        ///Carrega a tela
        private void Form1_Load(object sender, EventArgs e)
        {

            if (!File.Exists(Directory.GetCurrentDirectory() + @"\config.ini"))
            {
                TesteBludata.Estado estado = new TesteBludata.Estado();
                estado.ShowDialog();
            }

            estado = File.ReadLines(Directory.GetCurrentDirectory() + @"\config.ini").First();

            dgrvPessoas.DataSource = DB.Pessoa.Select(a => new { Código = a.id,
                                                                 CPF = a.cpf,
                                                                 RG  = a.rg,
                                                                 Nome = a.nome,
                                                                 Nascimento = a.data_nasc,
                                                                // Telefones = string.Join(", ", from item in a.Telefone select item.num_tel),
                                                                 Cadastro = a.data_cad}).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.estado   = estado;
            cad.form = this;
            cad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filtrar filtrar = new Filtrar();
            filtrar.form    = this;
            filtrar.ShowDialog();

        }

        public void limpaFiltro()
        {
            fil_cpf = "";
            fil_nome = "";
            fil_dat_nasc_ini = DateTime.MinValue;
            fil_dat_nasc_fim = DateTime.MaxValue;
            fil_dat_cad_ini = DateTime.MinValue;
            fil_dat_cad_fim = DateTime.MaxValue;

            reloadGrid();
        }
        // Recarrega Grid.
        public void reloadGrid()
        {
            DateTime dat_cad_fim = fil_dat_cad_fim == DateTime.MaxValue? fil_dat_cad_fim:fil_dat_cad_fim.AddDays(1);
            DateTime dat_nasc_fim = fil_dat_nasc_fim == DateTime.MaxValue? fil_dat_nasc_fim:fil_dat_nasc_fim.AddDays(1);

            dgrvPessoas.DataSource = DB.Pessoa.Where(a => (a.nome.Contains(fil_nome) || fil_nome == "") &&
                                                          (a.data_cad >= fil_dat_cad_ini && a.data_cad < dat_cad_fim) &&
                                                          (a.data_nasc >= fil_dat_nasc_ini && a.data_nasc < dat_nasc_fim)).Select(a => new {
                                                              Código = a.id,
                                                              CPF = a.cpf,
                                                              RG = a.rg,
                                                              Nome = a.nome,
                                                              Nascimento = a.data_nasc,
                                                              // Telefones = string.Join(", ", from item in a.Telefone select item.num_tel),
                                                              Cadastro = a.data_cad
                                                          }).ToList();
        }

        private void btnLimpaFiltro_Click(object sender, EventArgs e)
        {
            limpaFiltro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.estado = estado;
            cad.form = this;
            cad.idPessoa = Convert.ToInt16(dgrvPessoas.Rows[dgrvPessoas.CurrentCell.RowIndex].Cells[0].Value.ToString());
            cad.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dgrvPessoas.Rows[dgrvPessoas.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DB.Telefone.RemoveRange(DB.Telefone.Where(a => a.id_pessoa == id).ToList());
            DB.Pessoa.Remove(DB.Pessoa.Where(a => a.id == id).First());
            DB.SaveChanges();
            reloadGrid();
        }
    }
}
