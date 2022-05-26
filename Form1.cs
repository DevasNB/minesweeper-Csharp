using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Conexão base dados :
        string connectionString = @"Integrated Security=True;Data Source=DEVASNB-PC;Initial Catalog=minesweeperJogos;";
        SqlConnection cnn= new SqlConnection(@"Integrated Security=True;Data Source=DEVASNB-PC;Initial Catalog=minesweeperJogos;");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader reader;
        string commando_sql;

        int linhas = 0, colunas = 0, minas = 0;
        int[,] campo = new int[0, 0];

        int pontuacao = 0, pontuacao_max = 0, ganhou = 0;
        int pontos_tempo = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            carregar_pontuaçoes();
        }

        public void carregar_pontuaçoes() { 
            cnn.Open();

            commando_sql = "Select TOP 3 * from jogos ORDER BY pontos DESC;";
            command = new SqlCommand(commando_sql, cnn);

            reader = command.ExecuteReader();

            int t = 1;
            while (reader.Read())
            {
                string top_nome = reader["nome"].ToString(),
                       top_pontos = reader["pontos"].ToString(),
                       top_tempo = reader["tempo"].ToString();
                switch (t)
                {
                    case 1:
                        lbl_t1_nome.Text = top_nome;
                        lbl_t1_pontucacao.Text = top_pontos;
                        lbl_t1_tempo.Text = top_tempo;
                        break;

                    case 2:
                        lbl_t2_nome.Text = top_nome;
                        lbl_t2_pontucacao.Text = top_pontos;
                        lbl_t2_tempo.Text = top_tempo;
                        break;

                    case 3:
                        lbl_t3_nome.Text = top_nome;
                        lbl_t3_pontucacao.Text = top_pontos;
                        lbl_t3_tempo.Text = top_tempo;
                        break;
                }

                t++;
            }

            command.Dispose();
            cnn.Close();
        }

        private void btn_jog_sair_Click(object sender, EventArgs e)
        {

        }

        private void tmr_pontuacao_tempo_Tick(object sender, EventArgs e)
        {
            pontos_tempo++;
            lbl_tempo.Text = pontos_tempo.ToString();
        }

        private void btn_Comecar_Click(object sender, EventArgs e)
        {
            if (txb_jog_nome.Text == "")
            {
                //MessageBox.Show("Preencha o campo do nome");
                final.Text = "Preencha o campo do nome";
                final.ForeColor = Color.Red;
                final.BackColor = Color.White;
            }
            else
            {
                gb_jogador.Enabled = false;
                gb_dificuldade.Enabled = false;

                if (rb_dif_facil.Checked == true)
                {
                    linhas = 4;
                    colunas = 4;
                    minas = 5;
                }
                else if (rb_dif_medio.Checked == true)
                {
                    linhas = 5;
                    colunas = 5;
                    minas = 8;
                }
                else if (rb_dif_dificil.Checked == true)
                {
                    linhas = 6;
                    colunas = 6;
                    minas = 16;
                }
                else if (rb_dif_extremo.Checked == true)
                {
                    linhas = 7;
                    colunas = 7;
                    minas = 28;
                }
                else if (rb_dif_impossivel.Checked == true)
                {
                    linhas = 8;
                    colunas = 8;
                    minas = 40;
                }

                //  Definir pontuação maxima para depois acabar o jogo
                pontuacao_max = (linhas * colunas) - minas;

                //  Criar o campo com as linhas e colunas que o jogador escolheu
                campo = new int[linhas, colunas];

                //  Resetar alguns controlos
                btn_Comecar.Enabled = false;
                flp_campo.Controls.Clear();

                final.Text = " ";
                final.BackColor = Color.Transparent;

                pontuacao = 0;
                pontos_tempo = 0;

                lbl_tempo.Text = "0";
                lbl_pontuacao.Text = "0";

                Random random = new Random();
                int pos_mina = 0;

                //  Array que guadra a posição das minas
                int[] arr_minas = new int[minas];

                //  Preencher o mesmo array com posições aleatorias
                for (int i = 0; i < arr_minas.Length;)
                {
                    pos_mina = random.Next(0, linhas * colunas);

                    if (!(arr_minas.Contains(pos_mina)))
                    {
                        arr_minas[i] = pos_mina;
                        i++;
                    }

                }

                //  Ordenar o Array
                Array.Sort(arr_minas);

                int pos = 0;
                int mina_num = 0;

                //Preenches a matriz de espaços e minas
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (pos == arr_minas[mina_num])
                        {
                            //  Por a mina no campo
                            campo[i, j] = 1;
                            mina_num++;

                            //  Verificar se todas as minas foram posicionadas
                            if (mina_num == minas)
                                break;
                        }
                        pos++;
                    }
                    //  Verificar se todas as minas foram posicionadas
                    if (mina_num == minas)
                        break;
                }

                //Por no ecrã
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Button btnPos = new Button();

                        //  Propriadades do Botão
                        btnPos.Name = i.ToString() + "_" + j.ToString();
                        btnPos.Size = new System.Drawing.Size(40, 40);
                        btnPos.Text = "?";
                        btnPos.UseVisualStyleBackColor = true;

                        //  Se é uma mina ou não
                        if (campo[i, j] == 1)
                        {
                            btnPos.Tag = true;
                        }
                        else
                        {
                            btnPos.Tag = false;
                        }

                        btnPos.Click += BtnPos_Click;
                        flp_campo.Controls.Add(btnPos);

                        //  Nova linha
                        if (j == colunas - 1)
                        {
                            flp_campo.SetFlowBreak(btnPos, true);
                        }
                    }
                }
                tmr_pontuacao_tempo.Start();
            }
        }

        private void BtnPos_Click(object sender, EventArgs e)
        {            
            Button btn = (Button)sender;
            bool tag = (bool)btn.Tag;
            //MessageBox.Show(btn.Name);

            if (tag)
            {
                //  Como é uma mina rebenta e perde
                tmr_pontuacao_tempo.Stop();

                btn.BackColor = Color.Red;

                for (int i = 0; i < (colunas*linhas); i++)
                {
                    //  Como perdeu mostra onde estavam as minas
                    if( (bool)flp_campo.Controls[i].Tag == true )
                    {
                        flp_campo.Controls[i].BackColor = Color.Red;
                        flp_campo.Controls[i].Text = " ";
                        
                    }
                    flp_campo.Controls[i].Enabled = false;
                }

                //MessageBox.Show("Game Over");
                final.Text = "GAME OVER";
                final.ForeColor = Color.Red;
                final.BackColor = Color.White;

                btn_Comecar.Enabled = true;
                gb_dificuldade.Enabled = true;

                cnn.Open();

                commando_sql = "Insert into jogos values('" + txb_jog_nome.Text + "','" + pontuacao + "','" + pontos_tempo + "')";
                command = new SqlCommand(commando_sql, cnn);
                adapter.InsertCommand = new SqlCommand(commando_sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
            }
            else
            {
                //  Não é uma mina então ganha um ponto
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.Red;
                pontuacao++;

                lbl_pontuacao.Text = pontuacao.ToString();

                //  Pegar cordenadas para depois verificar minas á volta
                int x = Int32.Parse((btn.Name).Split('_')[0]);
                int y = Int32.Parse((btn.Name).Split('_')[1]);
                contar_minas_a_volta(x, y, btn);

                //  Caso tenha clicado em todos os espaços sem minas o jogador ganha e são mostradas onde estavam as outras minas
                if (pontuacao == pontuacao_max)
                {
                    tmr_pontuacao_tempo.Stop();
                    ganhou++;                    

                    for (int i = 0; i < (colunas * linhas); i++)
                    {
                        /*Button btemp = (Button)flp_campo.Controls[i];
                        btemp.PerformClick();*/

                        if ((bool)flp_campo.Controls[i].Tag == true)
                        {
                            flp_campo.Controls[i].BackColor = Color.Yellow;
                            flp_campo.Controls[i].Text = " ";
                        }
                        flp_campo.Controls[i].Enabled = false;
                    }

                    //MessageBox.Show("Você ganhou!");
                    final.Text = "VOCÊ GANHOU!";
                    final.ForeColor = Color.Lime;
                    final.BackColor = Color.White;

                    btn_Comecar.Enabled = true;
                    gb_dificuldade.Enabled = true;

                    cnn.Open();

                    commando_sql = "Insert into jogos values('" + txb_jog_nome.Text + "','" + pontuacao + "','" + pontos_tempo + "')";
                    command = new SqlCommand(commando_sql, cnn);
                    adapter.InsertCommand = new SqlCommand(commando_sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    cnn.Close();                    

                }
            }

            btn.Enabled = false;
            btn_focus.Focus();
            carregar_pontuaçoes();
        }

        public void contar_minas_a_volta(int x, int y, Button btn)
        {
            int minas_a_volta = 0;

            int ym1 = y - 1;
            int yM1 = y + 1;

            int xm1 = x - 1;
            int xM1 = x + 1;

            int l = linhas - 1;
            int c = colunas - 1;

            //  Diagonal superior esquerda
            if ( (xm1 >= 0) && (ym1 >= 0) && (campo[xm1, ym1] == 1))
                minas_a_volta++;

            //  Cima
            if ( (xm1 >= 0) && (campo[xm1, y] == 1) )
                minas_a_volta++;

            //  Diagonal superior direita
            if ( (xm1 >= 0) && (yM1 <= c) && (campo[xm1, yM1] == 1) )
                minas_a_volta++;

            //Esquerda
            if ( (ym1 >= 0) && (campo[x, ym1] == 1) )
                minas_a_volta++;

            //  Direita
            if ( (yM1 <= c) && (campo[x, yM1] == 1) )
                minas_a_volta++;

            //  Diagonal inferior esquerda
            if ( (xM1 <= l) && (ym1 >= 0) && (campo[xM1, ym1] == 1) )
                minas_a_volta++;

            //  Baixo
            if ( (xM1 <= l) &&(campo[xM1, y] == 1) )
                minas_a_volta++;

            //  Diagonal inferior direita
            if ( (xM1 <= l) && (yM1 <= c) && (campo[xM1, yM1] == 1) )
                minas_a_volta++;

            btn.Text = minas_a_volta.ToString();
            btn.Font = new Font("Arial", 21, FontStyle.Bold);           
        
        }
    }
}
