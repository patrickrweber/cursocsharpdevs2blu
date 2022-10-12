using Devs2Blu.ProjetosAulas.AgendaDeContatos.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AgendaDeContatos.Data
{
    public class ContatoRepository
    {
        public void InserirContato(Contato contato)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 19).Value = contato.Telefone;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = contato.Email;
                cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 20).Value = contato.Celular;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = contato.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contato.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = contato.Bairro;
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = contato.CEP;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = contato.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = contato.UF;

                cmd.ExecuteReader();
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, "Erro ao inserir contato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetContatos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {                
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (Exception)
            {

                throw;
            }
        }
        


        #region SQL

        const String SQL_INSERT_CONTATO = @"INSERT INTO contatos (
nome,
telefone,
email,
celular,
rua,
numero,
bairro,
cep,
cidade,
uf)
VALUES(
@nome,
@telefone,
@email,
@celular,
@rua,
@numero,
@bairro,
@cep,
@cidade,
@uf)";
        const String SQL_SELECT_CONTATO = @"SELECT 
nome,
telefone,
celular,
email,
cep,
rua,
numero,
bairro,
cidade,
uf
FROM contatos";

        #endregion
    }
}
