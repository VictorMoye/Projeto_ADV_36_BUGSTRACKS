using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_36_BUGSTRACKS
{
    // herda a classe SqlServe
    class Setor:SqlServer
    {
        ///<summary>
        ///recebe o dataSet Bubs tracks e alimenta a tabela 
        ///</summary> 
        ///<param name="ds">Representa uma instacia do dataSet</param>
        public void GetSetores(BugstracksDataSet ds)
        {
            // cria a query sql 
            string query = "SELECT id,setor FROM setores ORDER BY setor ASC;"; 
 
            // cria uma nova instancia do SqlCommand, passa a query e a conexão ativa 
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            // define o tipo de comando 
            this.cmd.CommandType = System.Data.CommandType.Text; 
 
            // cria umannova instancia do SqlDtaAdapter , pasaando o comando 
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd); 

            // preenche a tabela 'setores' do dataset recebido por parâmetro 
            this.adp.Fill(ds.setores);
        }


    }
}
