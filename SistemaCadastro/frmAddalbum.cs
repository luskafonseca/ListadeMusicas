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
    public partial class frmAddalbum : Form
    {
        public frmAddalbum()
        {
            InitializeComponent();
            listaAlbum();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereAlbum(txtaddAlbum.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Genero adicionado com sucesso");
            txtaddAlbum.Clear();
            txtaddAlbum.Focus();
            listaAlbum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            formSistema.ShowDialog();
            this.Close();
        }

        void listaAlbum()
        {
            ConectaBanco con = new ConectaBanco();
            dgAlbum.DataSource = con.listaAlbum();
            dgAlbum.Columns["idalbums"].Visible = false;

        }

        private void btnRemoveAlbum_Click(object sender, EventArgs e)
        {

            int linha = dgAlbum.CurrentRow.Index;
            int id = Convert.ToInt32(
                dgAlbum.Rows[linha].Cells["idalbums"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir esse album?", "Remove Album", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaAlbum(id);
                if (retorno == true)
                {
                    MessageBox.Show("Album Excluido com sucesso!");
                    listaAlbum();
                } // fim if retorno
                else
                    MessageBox.Show(con.mensagem);
            } // fim if ok calcel
            else
                MessageBox.Show("Exclusão Cancelada!");
        }

        private void dgAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
