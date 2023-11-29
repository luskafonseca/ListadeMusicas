using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class frmaddGenero : Form
    {
        public frmaddGenero()
        {
            InitializeComponent();
            listaGeneros();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereGenero(txtaddGenero.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Genero adicionado com sucesso");
            txtaddGenero.Clear();
            txtaddGenero.Focus();
            listaGeneros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            formSistema.ShowDialog();
            this.Close();
            
        }

        private void dgGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void listaGeneros()
        {
            ConectaBanco con = new ConectaBanco();
            dgGenero.DataSource = con.listaGeneros();
            dgGenero.Columns["idgenero"].Visible = false;

        }

        private void frmaddGenero_Load(object sender, EventArgs e)
        {

        }
    }
}
