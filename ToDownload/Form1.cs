using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using System.Data.SqlClient;

namespace ToDownload
{
    public partial class Form1 : MetroForm
    {

        SqlCommand comando;
        string StringSQL;
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ToDownloadBD;Data Source=(LocalDB)\JSERVER");


        public Form1()
        {
           
                         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDownloadBDDataSet.arquivo' table. You can move, or remove it, as needed.

            this.arquivoTableAdapter.Fill(this.toDownloadBDDataSet.arquivo);

            //MetroFramework.MetroMessageBox.Show(this, erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
            notificacao.BalloonTipText = "Olá!!";
            notificacao.ShowBalloonTip(1);

        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new addFile();
            add.Show();
            this.Hide();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                StringSQL = " delete from arquivo where nome=@nome";
                comando = new SqlCommand(StringSQL, conexao);

                comando.Parameters.AddWithValue("@nome", textBox1.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MetroFramework.MetroMessageBox.Show(this, erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
            }
            finally
            {
                conexao.Close();
                MetroFramework.MetroMessageBox.Show(this, "Arquivo eliminado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                
            }
            this.arquivoTableAdapter.Fill(this.toDownloadBDDataSet.arquivo);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
