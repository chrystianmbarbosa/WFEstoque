using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public enum EStatus
    {
        Ativo = 1,
        Inativo = 0
    }

    public class Produto
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public EStatus Status {  get; set; }

        public static List<Produto> ListaProdutos = new List<Produto>();


        public bool Cadastrar()
        {
            int afetados = 0;
            using (MySqlConnection con = new MySqlConnection(
                "Server=localhost;Database=bdProduto;Uid=root"))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO produto (idProduto, nome, preco, quantidade, status) ");
                sql.Append("VALUES(@idProduto,@nome,@preco,@quantidade,@status);");

                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);

                cmd.Parameters.AddWithValue("@idProduto", this.Id);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@preco", this.Preco);
                cmd.Parameters.AddWithValue("@quantidade", this.Quantidade);
                cmd.Parameters.AddWithValue("@status", this.Status.ToString());

                con.Open();
                afetados = cmd.ExecuteNonQuery();
            }
            return (afetados > 0);
        }

    }
}
