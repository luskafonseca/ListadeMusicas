using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665927;password=3GsSJMSuTc;database=sql10665927");
        public string mensagem;

        public bool insereMusica(Musica novaMusica)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereMusica", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("artista", novaMusica.Artista);
                cmd.Parameters.AddWithValue("nomemusica", novaMusica.Nomemusica);
                cmd.Parameters.AddWithValue("genero", novaMusica.Genero);
                cmd.Parameters.AddWithValue("anolancamento", novaMusica.Anolancamento);
                cmd.Parameters.AddWithValue("feats", novaMusica.Feat);
                cmd.Parameters.AddWithValue("album", novaMusica.Album);
                cmd.ExecuteNonQuery();
                return true;
            } catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public DataTable listaGeneros()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaGeneros", conexao);
            cmd.CommandType =CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally { 
                conexao.Close(); 
            }

        } // fiim lista genero

        public DataTable listaMusicas()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaMusica", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        } // fim lista musicas


        public bool deletaMusica(int idRemovemusica)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeMusica", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idmusica", idRemovemusica);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); 
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta musica

        public bool alteraMusica(Musica b, int idmusica)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraMusica", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idmusica", idmusica);
            cmd.Parameters.AddWithValue("artista", b.Artista);
            cmd.Parameters.AddWithValue("nomemusica", b.Nomemusica);
            cmd.Parameters.AddWithValue("genero", b.Genero);
            cmd.Parameters.AddWithValue("anolancamento", b.Anolancamento);
            cmd.Parameters.AddWithValue("feats", b.Feat);
            cmd.Parameters.AddWithValue("album", b.Album);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim update banda

        public bool insereGenero(string nomeGenero)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereGenero", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeGenero", nomeGenero);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        } // fim insere genero
        public bool deletaGenero(int idRemovegenero)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeGenero", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idgenero", idRemovegenero);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta genero

        public bool insereAlbum(string nomeAlbum)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereAlbum", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeAlbum", nomeAlbum);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        } // fim insere genero
        public bool deletaAlbum(int idRemovealbum)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeAlbum", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idalbum", idRemovealbum);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta musica

        public DataTable listaAlbum()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaAlbum", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        } // fiim lista album

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }



    }

}


