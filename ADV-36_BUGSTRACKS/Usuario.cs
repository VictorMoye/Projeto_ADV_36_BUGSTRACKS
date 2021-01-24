using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_36_BUGSTRACKS
{
    class Usuario : SqlServer
    {
        public void GetUsuarios(BugstracksDataSet ds) 
        {
            // query sql 
            string query = "SELECT id, nome FROM usuarios ORDER BY nome ASC;";

            // cria uma nova instancia de classe SqlCommand 
            // pasando a query e a conexão com o banco de dados
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            // define o tipo de comando 
            this.cmd.CommandType = System.Data.CommandType.Text;

            // cria uma nova instancia do SqlDtaAdapter , pasando a instancia do  sql  
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            // preenche a tabela 'usuario' do dataset recebido por parâmetro 
            this.adp.Fill(ds.usuarios);
        }

     
    }
}
