using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADV_36_BUGSTRACKS
{
    ///<summary>
    ///abstract : não permite nova instancia apenas ser herdada 
    ///</summary>
        
    abstract class SqlServer
    {
        // atributos privados 
        private SqlConnection sqlConn; 

        // atributos protegidos 
        // SqlCommand é a classe responsavel por enviar e receber comandos 
        // requer uma conexão ativa 
        protected SqlCommand cmd; 

        // SqlDataAdapter é a classe que recebe a coleção retornada pelo 
        // banco de dados e preenche a atabela informada  
        protected SqlDataAdapter adp; 

        // SqlDataReader é a classe que faz a leitura linha a linha 
        // dos dados retornados pela a execução do comando SqlCommand.ExecuteReader() 
        protected SqlDataReader reader; 

        // DataTable é a classe usada para cria tabelas 
        protected DataTable tb; 

        // construtor padrão 
        protected SqlServer()
        {
            // cria uma nova instancia SqlConnection 
            this.sqlConn = new  SqlConnection(Properties.Settings.Default.strSQL);
           
        }
        
        // contrutopr custumizado 
        protected SqlServer(string strHost)
        {
            // cria uma instancia SqlConnection 
            this.sqlConn = new SqlConnection(strHost);
           
        }

        // propriedades de somente leitura  
        protected SqlConnection ConexaoAtiva
        {
            get 
            {
                // se a conexao estiver fechada abre 
                if (this.sqlConn.State == ConnectionState.Closed)
                    this.sqlConn.Open(); 

                // retorna a conexão 
                return this.sqlConn; 
            }
        }
    }
}
