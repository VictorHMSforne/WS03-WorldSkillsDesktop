using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS03
{
    public class Paciente
    {
        public int Id { get; set; }
        public string nome_paciente { get; set; }
        public string nome_doutor { get; set; }
        public string tipo_quarto { get; set; }
        public int quarto { get; set; }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\WS\\WS03\\DbEnfermagem.mdf;Integrated Security=True"); // dever de casa
        public List<Paciente> listapaciente()
        {

            List<Paciente> li = new List<Paciente>();
            conn.Open();
            string sql = "SELECT * FROM Paciente";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Id = (int)dr["Id"];
                paciente.nome_paciente = dr["nome_paciente"].ToString();
                paciente.nome_doutor = dr["nome_doutor"].ToString();
                paciente.tipo_quarto = dr["tipo_quarto"].ToString();
                paciente.quarto = (int)dr["quarto"];
                li.Add(paciente);
            }
            conn.Close();
            return li;
        }
        public List<Paciente> listaquarto(int quarto)
        {
            List<Paciente> li = new List<Paciente>();
            conn.Open();
            string sql = "SELECT * FROM Paciente WHERE = '" + quarto + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Id = (int)dr["Id"];
                paciente.nome_paciente = dr["nome_paciente"].ToString();
                paciente.nome_doutor = dr["nome_doutor"].ToString();
                paciente.tipo_quarto = dr["tipo_quarto"].ToString();
                paciente.quarto = (int)dr["quarto"];
                li.Add(paciente);
            }
            conn.Close();
            return li;
        }

        public void Localiza(int id)
        {
            conn.Open();
            string sql = "SELECT * FROM Paciente WHERE Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome_paciente = dr["nome_paciente"].ToString();
                nome_doutor = dr["nome_doutor"].ToString();
                tipo_quarto = dr["tipo_quarto"].ToString();
                quarto = (int)dr["quarto"];
            }
            conn.Close();
        }
        public void LocalizaQuarto(int quarto)
        {
            conn.Open();
            string sql = "SELECT * FROM Paciente WHERE quarto ='" + quarto + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome_paciente = dr["nome_paciente"].ToString();
                nome_doutor = dr["nome_doutor"].ToString();
                tipo_quarto = dr["tipo_quarto"].ToString();
                quarto = (int)dr["quarto"];
            }
            conn.Close();
        }
        public List<Paciente> listanome(string nome_paciente)
        {
            List<Paciente> li = new List<Paciente>();
            conn.Open();
            string sql = "SELECT * FROM Paciente WHERE nome_paciente = '" + nome_paciente + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Id = (int)dr["Id"];
                paciente.nome_paciente = dr["nome_paciente"].ToString();
                paciente.nome_doutor = dr["nome_doutor"].ToString();
                paciente.tipo_quarto = dr["tipo_quarto"].ToString();
                paciente.quarto = (int)dr["quarto"];
                li.Add(paciente);
            }
            conn.Close();
            return li;
        }

        public void Inserir(string nome_paciente, string nome_doutor, string tipo_quarto, int quarto)
        {
            string sql = "INSERT INTO Paciente(nome_paciente,nome_doutor,tipo_quarto,quarto) VALUES('" + nome_paciente + "','" + nome_doutor + "','" + tipo_quarto + "','" + quarto + "')";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public void Atualizar(int Id, string nome_paciente, string nome_doutor, string tipo_quarto, int quarto)
        {
            conn.Open();
            string sql = "UPDATE Paciente SET nome_paciente='" + nome_paciente + "',nome_doutor='" + nome_doutor + "',tipo_quarto='" + tipo_quarto + "',quarto='" + quarto + "' WHERE Id='" + Id + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Excluir(int Id)
        {
            conn.Open();
            string sql = "DELETE FROM Paciente WHERE Id='" + Id + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool RegistroRepetido(string nome_paciente)
        {
            conn.Open();
            string sql = "SELECT * FROM Paciente WHERE nome_paciente='" + nome_paciente + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                conn.Close();
                return false;
                
            }
            conn.Close();
            return true;

        }

        public bool ValidaQuarto(string tipo_quarto, int quarto)
        {
            conn.Open();
            string sql = "SELECT tipo_quarto, count(quarto) as numero FROM Paciente WHERE quarto='" + quarto + "' AND tipo_quarto='"+tipo_quarto+"' GROUP BY tipo_quarto";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result == null)
            {
                conn.Close();
                return  false;
            }
            else
            {
                
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tipo_quarto = dr["tipo_quarto"].ToString().Trim();
                    quarto = (int)dr["numero"];
                }
                if (tipo_quarto == "Solteiro" && quarto == 1)
                {
                    return true;
                }

                if (tipo_quarto == "Duplo" && quarto == 2)
                {
                    return true;
                }
                else if (tipo_quarto == "Triplo" && quarto == 3)
                {
                    return true;
                }
                conn.Close();
                return false;
            }
            
            
            //   var result = 0;
            //if (quarto == 1)
            //{
            //    quarto += 1;
            //    return true;

            //}
            
        }
    }
}
