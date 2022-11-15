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
    public class CompromissoRepository
    {
        public void InserirCompromisso(Compromisso compromisso, Int32 idContato )
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idContato;
                cmd.Parameters.Add("@datacompromisso", MySqlDbType.DateTime).Value = compromisso.Data;
                cmd.Parameters.Add("@localcompromisso", MySqlDbType.VarChar, 45).Value = compromisso.Local;
                cmd.Parameters.Add("@diassemana", MySqlDbType.VarChar, 45).Value = compromisso.DiaSemana;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = compromisso.Descricao;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.ExecuteReader();
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, "Erro ao inserir compromisso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetCompromissos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirCompromissos(Int32 id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_COMPROMISSO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteReader();
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, "Erro ao excluir compromisso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void AlterarCompromissos(Compromisso compromisso, Int32 idContato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idContato;
                cmd.Parameters.Add("@datacompromisso", MySqlDbType.DateTime).Value = compromisso.Data;
                cmd.Parameters.Add("@localcompromisso", MySqlDbType.VarChar, 45).Value = compromisso.Local;
                cmd.Parameters.Add("@diassemana", MySqlDbType.VarChar, 45).Value = compromisso.DiaSemana;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 20).Value = compromisso.Descricao;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.ExecuteReader();
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, "Erro ao alterar compromisso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQL

        const String SQL_INSERT_COMPROMISSO = @"insert into compromissos (
id_contatos,
datacompromisso,
localcompromisso,
diassemana,
descricao,
titulo
)
values(
@id,
@datacompromisso,
@localcompromisso,
@diassemana,
@descricao,
@titulo
)";
        const String SQL_SELECT_COMPROMISSO = @"select 
com.id_contatos as id,
con.nome,
com.titulo,
com.descricao,
com.localcompromisso,
com.datacompromisso,
com.diassemana
from contatos as con
join compromissos as com
on com.id_contatos = con.id 
order by id";
        const String SQL_DELETE_COMPROMISSO = @"Delete from compromissos where id_contatos = @id";
        const String SQL_UPDATE_COMPROMISSO = @"update compromissos set
datacompromisso = @datacompromisso,
localcompromisso = @localcompromisso,
diassemana = @diassemana,
descricao = @descricao,
titulo = @titulo
where id_contatos = @id";
        #endregion
    }
}
