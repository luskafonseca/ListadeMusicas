using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
           
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            ListaCBGenero();
            ListaCBAlbum();
            listaMusicas();
                 }

        public void ListaCBGenero()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaGeneros();
            cbGenero.DataSource = tabelaDados;
            cbGenero.DisplayMember = "genero";
            cbGenero.ValueMember = "idgenero";

            cbAlteraGenero.DataSource = tabelaDados;
            cbAlteraGenero.DisplayMember = "genero";
            cbAlteraGenero.ValueMember = "idgenero";

        }

        public void ListaCBAlbum()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaAlbum();
            cbAlbum.DataSource = tabelaDados;
            cbAlbum.DisplayMember = "album";
            cbAlbum.ValueMember = "idalbums";

            cbAlteraAlbum.DataSource = tabelaDados;
            cbAlteraAlbum.DisplayMember = "album";
            cbAlteraAlbum.ValueMember = "idalbums";
        }



        void listaMusicas()
        {
            ConectaBanco con = new ConectaBanco();
            dgMusicas.DataSource = con.listaMusicas();
            dgMusicas.Columns["idmusicas"].Visible = false;

        }
     


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgMusicas.DataSource as DataTable).DefaultView.RowFilter = string.Format("nomemusica like '{0}%'", txtBusca.Text);
  
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
                int linha = dgMusicas.CurrentRow.Index;// pega a linha selecionada
                idAlterar = Convert.ToInt32(
                  dgMusicas.Rows[linha].Cells["idmusicas"].Value.ToString());
                txtAlteraArtista.Text =
                     dgMusicas.Rows[linha].Cells["artista"].Value.ToString();
                txtAlteraNomemusica.Text =
                    dgMusicas.Rows[linha].Cells["nomemusica"].Value.ToString();
                txtAlteraAno.Text =
                    dgMusicas.Rows[linha].Cells["anolancamento"].Value.ToString();
                cbAlteraGenero.Text =
                    dgMusicas.Rows[linha].Cells["genero"].Value.ToString();
                txtAlteraFeat.Text =
                    dgMusicas.Rows[linha].Cells["feats"].Value.ToString();  
                cbAlteraAlbum.Text =
                    dgMusicas.Rows[linha].Cells["album"].Value.ToString();
                tabControl1.SelectedTab = tabAlterar;// muda aba
         
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Musica novaMusica = new Musica();
            novaMusica.Artista = txtAlteraArtista.Text;
            novaMusica.Nomemusica = txtAlteraNomemusica.Text;
            novaMusica.Anolancamento = Convert.ToInt32(txtAlteraAno.Text);
            novaMusica.Genero = Convert.ToInt32(cbAlteraGenero.SelectedValue.ToString());
            novaMusica.Feat = txtAlteraFeat.Text;
            novaMusica.Album = Convert.ToInt32(cbAlteraAlbum.SelectedValue.ToString());
            bool retorno = con.alteraMusica(novaMusica, idAlterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso!");
            
            limpaCamposAltera();
            listaMusicas();


        }

        void limpaCamposAltera()
        {
            txtAlteraArtista.Clear();
            cbAlteraGenero.Text = "";
            cbAlteraAlbum.Text = "";
            txtAlteraNomemusica.Clear();
            txtAlteraFeat.Clear();
            txtAlteraAno.Clear();
            txtAlteraArtista.Focus();
        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
            frmaddGenero formGenero = new frmaddGenero();
            this.Hide();
            formGenero.ShowDialog();
            this.Close();
        }

        void limpaCampos()
        {
            txtartista.Clear();
            cbGenero.Text = "";
            cbAlbum.Text = "";
            txtnomemusica.Clear();
            txtfeat.Clear();
            txtanolancamento.Clear();
            txtartista.Focus();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Musica novaMusica = new Musica();
            novaMusica.Artista = txtartista.Text;
            novaMusica.Nomemusica = txtnomemusica.Text;
            novaMusica.Anolancamento = Convert.ToInt32(txtanolancamento.Text);
            novaMusica.Feat = txtfeat.Text;
            novaMusica.Genero =Convert.ToInt32(cbGenero.SelectedValue.ToString());
            novaMusica.Album = Convert.ToInt32(cbAlbum.SelectedValue.ToString());
            bool retorno = con.insereMusica(novaMusica);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Inserido com sucesso!");

            limpaCampos();
            listaMusicas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgBandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveMusica_Click(object sender, EventArgs e)
        {

            int linha = dgMusicas.CurrentRow.Index;
            int id = Convert.ToInt32(
                dgMusicas.Rows[linha].Cells["idmusicas"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir essa música?", "Remove Musica", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaMusica(id);
                if (retorno == true)
                {
                    MessageBox.Show("Musica Excluida com sucesso!");
                    listaMusicas();
                } // fim if retorno
                else
                    MessageBox.Show(con.mensagem);
            } // fim if ok calcel
            else
                MessageBox.Show("Exclusão Cancelada!");
        }

        private void txtAlteraRanking_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabAlterar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddalbum formAlbum = new frmAddalbum();
            this.Hide();
            formAlbum.ShowDialog();
            this.Close();
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://open.spotify.com/intl-pt/artist/2faWB48FCrYvPlxAoSaBmg?si=dXoEOVE9TSCw4z4OIBJ8Iw");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://deezer.page.link/QxJB5pyqsSgoRzhr6");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC5PXPTaaNRxBqfzvgBUBp2g");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://music.apple.com/br/artist/luzk/1017784505");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portfolio-luskafonseca.vercel.app/");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://open.spotify.com/intl-pt/artist/2faWB48FCrYvPlxAoSaBmg?si=dXoEOVE9TSCw4z4OIBJ8Iw");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void marcador_Paint(object sender, PaintEventArgs e)
        {
                
        }
    }
}
