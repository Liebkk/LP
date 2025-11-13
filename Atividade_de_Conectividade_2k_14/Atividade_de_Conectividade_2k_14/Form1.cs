using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_de_Conectividade_2k_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            //Inicio do código do Evento Click
            if (txt_Id.Text == null || txt_Id.Text == "")
            {
                MessageBox.Show("Valor Invalido, informe a ID do Autor...", "Sistema de Busca");
            }
            else
            {
                //Criando a variável strCon
                string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=biblioteca";
                //Criar e Instanciar Objeto de Conexão com o Banco de Dados
                NpgsqlConnection conectar = new NpgsqlConnection(strCon);
                //Criando a variável de strSQL, Concatenando a informação do objeto txt_id
                string strSQL = "select * from autores where id_autor = '" + txt_Id.Text + "'";
                //Criar o Objeto de commando (command) para armazenar a (Query) comando SQL
                NpgsqlCommand comandoSQL = new NpgsqlCommand(strSQL, conectar);
            }
            //Bloco try/catch serve para tratamento de exceções (Possíveis Falhas e Erros),
            //Tratamento de códigos que podem não ser totalmente atendidos e gerarem alguma exceção/erro.
            try
            {
                //Abrir Objeto de Conexão com Banco de Dados;
                conectar.Open();
                //Cria o Objeto datareader para fazer (executar) a conexão com a tabela
                NpgsqlDataReader lerDados = comandoSQL.ExecuteReader();
                if (lerDados.Read())
                {
                    txt_Nome.Text = lerDados.GetString(1);
                    txt_AnoN.Text = lerDados.GetInt16(2).ToString();
                }
                else
                {
                    MessageBox.Show("Registro não Localizado...", "Sistema de Busca");
                }
                //Fecha o DbDatareader
                lerDados.Close();
                //Fecha a conexao
                conectar.Close();
            }
            //Exibe possível Erro (exceção)...
            catch (Exception erro)
            {
                if (erro != null)
                {
                    MessageBox.Show("Error: " + erro.Message, "Sistema de Busca");
                }
            }
            //Voltando o cursor ao objeto txt_Id
            txt_Id.Focus();
            //Final do Else do If verificando se txt_Id era nulo/vazio
        }
        //Final do Evento Click

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            //Início do Código do Evento Click
            MessageBox.Show("Finalizando Sistema...", "Sistema de Busca");
            Application.Exit();
            //Final do Código do Evento Click
        }
    }
}
