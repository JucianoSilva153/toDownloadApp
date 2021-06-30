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
using System.Data.SqlClient;
namespace ToDownload
{

    public partial class addFile : MetroForm
    {

        SqlCommand comando;
        string StringSQL;
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ToDownloadBD;Data Source=(LocalDB)\JSERVER");
        bool pAlta, pMedia, pBaixa;
        string Prio;
        public addFile()
        {
            InitializeComponent();
        }

        private void rbtn_media_CheckedChanged(object sender, EventArgs e)
        {
            pAlta = false;
            pBaixa = false;
            pMedia = true;
        }

        private void rbtn_baixa_CheckedChanged(object sender, EventArgs e)
        {
            pAlta = false;
            pBaixa = true;
            pMedia = false;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(pAlta == true && pMedia == false && pBaixa == false)
            {
                Prio = "Alta";
            }else if( pAlta == false && pBaixa == true && pMedia == false)
            {
                Prio = "Baixa";
            }
            else if( pMedia == true && pBaixa == false && pAlta == false)
            {
                Prio = "Média";
            }


            try
            {

                StringSQL = " insert into arquivo (nome, tipo, prioridade, baixado ) values (@nome, @tipo, @prioridade, @baixado ) ";
                comando = new SqlCommand(StringSQL, conexao);

                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@tipo", cb_tipo.Text);
                comando.Parameters.AddWithValue("@prioridade", Prio);
                comando.Parameters.AddWithValue("@baixado", rbtn_sim.Checked ? "Sim" : "Não");

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                IWin32Window j;
                
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
                MetroFramework.MetroMessageBox.Show(this, "Arquivo Adicionado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }

            Form main = new Form1();
            main.Show();
            this.Close();
        }

        private void rbtn_alta_CheckedChanged(object sender, EventArgs e)
        {
            pAlta = true;
            pBaixa = false;
            pMedia = false;
        }

        
    }
}
