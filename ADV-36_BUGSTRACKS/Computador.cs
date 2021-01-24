
namespace ADV_36_BUGSTRACKS
{
    class Computador : SqlServer 
    {
 
        public void GetComputadores(BugstracksDataSet ds)
        {
            // query sql 
            string query = "SELECT id, computador FROM computadores ORDER BY computador ASC;"; 

            // cria uma nova instancia de classe SqlCommand 
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            
            // define o tipo de comando 
            this.cmd.CommandType = System.Data.CommandType.Text;

            // cria uma nova instancia do SqlDtaAdapter , pasaando o comando sql  
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            // preenche a tabela 'computador' do dataset recebido por parâmetro 
            this.adp.Fill(ds.computadores);
        }
    }
}
