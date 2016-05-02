using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.ComponentModel;
MongoDB.Driver.Builders;


namespace MongoDBApplication
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //String de conexão ao MongoDB
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase db = client.GetDatabase("ORCAMENTOS"); //Cria o "Banco" para armazenar os registros
                var docs = db.GetCollection<Orcamento>("OrcamentoTST"); //Collection corresponde a uma "tabela" do BD relacional

                //Classe com os atributos do orçamento
                Orcamento orc = new Orcamento();
                orc.codigo = txtCod.Text;
                orc.nome = txtNome.Text;
                orc.usuario = txtUser.Text;

                docs.InsertOneAsync(orc); //Insere o conteúdo no banco
                MessageBox.Show("Registro inserido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //String de conexão ao MongoDB
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("ORCAMENTOS");

            var q = 

            //BindingList<DocumentoClass> docList = new BindingList<DocumentoClass>();

            //foreach(var deger in colltion.f )

        }
    }
}
