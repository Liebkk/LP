using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectar_2k_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar uma variável com a string de Conexão
            //Pode copiar a string usando o menu do VS >> Ferramentas/Conectar a um BD/...
            //Inserir @ para aceitar as "\" (sem duplicar) dentro das aspas (")
            //versão 64 bits (accdb) - versão atual
            //string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\ColégioCruzeirodoSul\Documents\biblioteca.accdb";
            //versão 32 bits (mdb) - Gravar como versão 2002/2003 (MDB)
            string strCon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\ColégioCruzeirodoSul\Documents\biblioteca_2k_14_mdb.mdb";
            //Criar e Instanciar Objeto de Conexão com o Banco de Dados
            
            OleDbConnection conectar = new OleDbConnection(strCon);
            //Criar o Objeto de commando (command) para armazenar a (Query) comando SQL
            
            OleDbCommand comandoSQL = new OleDbCommand("select * from autores", conectar);
            //Bloco try/catch serve para tratamento de exceções (Possíveis Falhas e Erros),
            //Tratamento de códigos que podem não ser totalmente atendidos e gerarem alguma exceção/erro.
            
            try
            {
                //Abrir Objeto de Conexão com Banco de Dados;
                conectar.Open();
                //Cria o Objeto datareader para fazer (executar) a conexão com a tabela
                DbDataReader lerDados = comandoSQL.ExecuteReader();
                Console.WriteLine("Os valores retornados da tabela são : ");
                //Faz a interação com o banco de dados lendo os dados da tabela
                
                while (lerDados.Read())
                {
                    Console.WriteLine("Nome:" + lerDados.GetString(1) + " | " +
                    "Ano de Nascimento:" + lerDados.GetInt16(2));
                }
                //pausa 1
                Console.WriteLine("Final dos Registros! Pressionar Qualquer Tecla...");
                Console.ReadLine();
                
                //Fecha o DbDatareader
                lerDados.Close();
                
                //Fecha a conexao
                conectar.Close();
                
                //pausa Final
                Console.WriteLine("Tabela e Conexão Fechados...");
                Console.ReadLine();
            }
            
            //Exibe possivel Erro (exceção)...
            catch (Exception erro)
            {
                if (erro != null)
                {
                    Console.WriteLine("Error: " + erro.Message);
                }
            }
        }
    }
}
