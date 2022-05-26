namespace MineSweeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flp_campo = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Comecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pontuacao = new System.Windows.Forms.Label();
            this.btn_focus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.tmr_pontuacao_tempo = new System.Windows.Forms.Timer(this.components);
            this.gb_dificuldade = new System.Windows.Forms.GroupBox();
            this.rb_dif_impossivel = new System.Windows.Forms.RadioButton();
            this.rb_dif_extremo = new System.Windows.Forms.RadioButton();
            this.rb_dif_dificil = new System.Windows.Forms.RadioButton();
            this.rb_dif_medio = new System.Windows.Forms.RadioButton();
            this.rb_dif_facil = new System.Windows.Forms.RadioButton();
            this.gb_jogador = new System.Windows.Forms.GroupBox();
            this.txb_jog_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_t3_tempo = new System.Windows.Forms.Label();
            this.lbl_t3_pontucacao = new System.Windows.Forms.Label();
            this.lbl_t3_nome = new System.Windows.Forms.Label();
            this.lbl_t2_tempo = new System.Windows.Forms.Label();
            this.lbl_t2_pontucacao = new System.Windows.Forms.Label();
            this.lbl_t2_nome = new System.Windows.Forms.Label();
            this.lbl_t1_tempo = new System.Windows.Forms.Label();
            this.lbl_t1_pontucacao = new System.Windows.Forms.Label();
            this.lbl_t1_nome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.gb_dificuldade.SuspendLayout();
            this.gb_jogador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_campo
            // 
            this.flp_campo.BackColor = System.Drawing.Color.Transparent;
            this.flp_campo.BackgroundImage = global::MineSweeper.Properties.Resources.semitranparent4;
            this.flp_campo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_campo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flp_campo.Location = new System.Drawing.Point(215, 11);
            this.flp_campo.Name = "flp_campo";
            this.flp_campo.Size = new System.Drawing.Size(380, 380);
            this.flp_campo.TabIndex = 0;
            // 
            // btn_Comecar
            // 
            this.btn_Comecar.BackColor = System.Drawing.Color.White;
            this.btn_Comecar.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comecar.ForeColor = System.Drawing.Color.Red;
            this.btn_Comecar.Location = new System.Drawing.Point(10, 338);
            this.btn_Comecar.Name = "btn_Comecar";
            this.btn_Comecar.Size = new System.Drawing.Size(200, 54);
            this.btn_Comecar.TabIndex = 1;
            this.btn_Comecar.Text = "Começar";
            this.btn_Comecar.UseVisualStyleBackColor = false;
            this.btn_Comecar.Click += new System.EventHandler(this.btn_Comecar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pontuação :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pontuacao
            // 
            this.lbl_pontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontuacao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontuacao.ForeColor = System.Drawing.Color.Lime;
            this.lbl_pontuacao.Location = new System.Drawing.Point(107, 282);
            this.lbl_pontuacao.Name = "lbl_pontuacao";
            this.lbl_pontuacao.Size = new System.Drawing.Size(103, 23);
            this.lbl_pontuacao.TabIndex = 4;
            this.lbl_pontuacao.Text = "0";
            this.lbl_pontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_focus
            // 
            this.btn_focus.Location = new System.Drawing.Point(12, 456);
            this.btn_focus.Name = "btn_focus";
            this.btn_focus.Size = new System.Drawing.Size(22, 23);
            this.btn_focus.TabIndex = 6;
            this.btn_focus.Text = " ";
            this.btn_focus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tempo :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tempo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tempo.Location = new System.Drawing.Point(107, 305);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(102, 23);
            this.lbl_tempo.TabIndex = 10;
            this.lbl_tempo.Text = "0";
            this.lbl_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_pontuacao_tempo
            // 
            this.tmr_pontuacao_tempo.Interval = 1000;
            this.tmr_pontuacao_tempo.Tick += new System.EventHandler(this.tmr_pontuacao_tempo_Tick);
            // 
            // gb_dificuldade
            // 
            this.gb_dificuldade.BackColor = System.Drawing.Color.Transparent;
            this.gb_dificuldade.Controls.Add(this.rb_dif_impossivel);
            this.gb_dificuldade.Controls.Add(this.rb_dif_extremo);
            this.gb_dificuldade.Controls.Add(this.rb_dif_dificil);
            this.gb_dificuldade.Controls.Add(this.rb_dif_medio);
            this.gb_dificuldade.Controls.Add(this.rb_dif_facil);
            this.gb_dificuldade.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dificuldade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_dificuldade.Location = new System.Drawing.Point(10, 115);
            this.gb_dificuldade.Name = "gb_dificuldade";
            this.gb_dificuldade.Size = new System.Drawing.Size(200, 154);
            this.gb_dificuldade.TabIndex = 11;
            this.gb_dificuldade.TabStop = false;
            this.gb_dificuldade.Text = "Dificuldade";
            // 
            // rb_dif_impossivel
            // 
            this.rb_dif_impossivel.AutoSize = true;
            this.rb_dif_impossivel.Location = new System.Drawing.Point(7, 116);
            this.rb_dif_impossivel.Name = "rb_dif_impossivel";
            this.rb_dif_impossivel.Size = new System.Drawing.Size(183, 20);
            this.rb_dif_impossivel.TabIndex = 4;
            this.rb_dif_impossivel.Text = "Impossivel ( 8x8 40 minas )";
            this.rb_dif_impossivel.UseVisualStyleBackColor = true;
            // 
            // rb_dif_extremo
            // 
            this.rb_dif_extremo.AutoSize = true;
            this.rb_dif_extremo.Location = new System.Drawing.Point(7, 92);
            this.rb_dif_extremo.Name = "rb_dif_extremo";
            this.rb_dif_extremo.Size = new System.Drawing.Size(173, 20);
            this.rb_dif_extremo.TabIndex = 3;
            this.rb_dif_extremo.Text = "Extremo ( 7x7 28 minas )";
            this.rb_dif_extremo.UseVisualStyleBackColor = true;
            // 
            // rb_dif_dificil
            // 
            this.rb_dif_dificil.AutoSize = true;
            this.rb_dif_dificil.Location = new System.Drawing.Point(7, 68);
            this.rb_dif_dificil.Name = "rb_dif_dificil";
            this.rb_dif_dificil.Size = new System.Drawing.Size(157, 20);
            this.rb_dif_dificil.TabIndex = 2;
            this.rb_dif_dificil.Text = "Dificil ( 6x6 16 minas )";
            this.rb_dif_dificil.UseVisualStyleBackColor = true;
            // 
            // rb_dif_medio
            // 
            this.rb_dif_medio.AutoSize = true;
            this.rb_dif_medio.Location = new System.Drawing.Point(7, 44);
            this.rb_dif_medio.Name = "rb_dif_medio";
            this.rb_dif_medio.Size = new System.Drawing.Size(146, 20);
            this.rb_dif_medio.TabIndex = 1;
            this.rb_dif_medio.Text = "Medio ( 5x5 8 minas)";
            this.rb_dif_medio.UseVisualStyleBackColor = true;
            // 
            // rb_dif_facil
            // 
            this.rb_dif_facil.AutoSize = true;
            this.rb_dif_facil.Checked = true;
            this.rb_dif_facil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_dif_facil.Location = new System.Drawing.Point(7, 20);
            this.rb_dif_facil.Name = "rb_dif_facil";
            this.rb_dif_facil.Size = new System.Drawing.Size(143, 20);
            this.rb_dif_facil.TabIndex = 0;
            this.rb_dif_facil.TabStop = true;
            this.rb_dif_facil.Text = "Facil ( 4x4 5 minas )";
            this.rb_dif_facil.UseVisualStyleBackColor = true;
            // 
            // gb_jogador
            // 
            this.gb_jogador.BackColor = System.Drawing.Color.Transparent;
            this.gb_jogador.Controls.Add(this.txb_jog_nome);
            this.gb_jogador.Controls.Add(this.label4);
            this.gb_jogador.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_jogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_jogador.Location = new System.Drawing.Point(10, 12);
            this.gb_jogador.Name = "gb_jogador";
            this.gb_jogador.Size = new System.Drawing.Size(200, 96);
            this.gb_jogador.TabIndex = 12;
            this.gb_jogador.TabStop = false;
            this.gb_jogador.Text = "Jogador";
            // 
            // txb_jog_nome
            // 
            this.txb_jog_nome.ForeColor = System.Drawing.Color.Red;
            this.txb_jog_nome.Location = new System.Drawing.Point(6, 54);
            this.txb_jog_nome.Name = "txb_jog_nome";
            this.txb_jog_nome.Size = new System.Drawing.Size(188, 30);
            this.txb_jog_nome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Top";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::MineSweeper.Properties.Resources.semitranparent4;
            this.groupBox2.Controls.Add(this.lbl_t3_tempo);
            this.groupBox2.Controls.Add(this.lbl_t3_pontucacao);
            this.groupBox2.Controls.Add(this.lbl_t3_nome);
            this.groupBox2.Controls.Add(this.lbl_t2_tempo);
            this.groupBox2.Controls.Add(this.lbl_t2_pontucacao);
            this.groupBox2.Controls.Add(this.lbl_t2_nome);
            this.groupBox2.Controls.Add(this.lbl_t1_tempo);
            this.groupBox2.Controls.Add(this.lbl_t1_pontucacao);
            this.groupBox2.Controls.Add(this.lbl_t1_nome);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(602, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 194);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Melhores Pontuações";
            // 
            // lbl_t3_tempo
            // 
            this.lbl_t3_tempo.Location = new System.Drawing.Point(301, 154);
            this.lbl_t3_tempo.Name = "lbl_t3_tempo";
            this.lbl_t3_tempo.Size = new System.Drawing.Size(98, 23);
            this.lbl_t3_tempo.TabIndex = 31;
            this.lbl_t3_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t3_pontucacao
            // 
            this.lbl_t3_pontucacao.Location = new System.Drawing.Point(196, 154);
            this.lbl_t3_pontucacao.Name = "lbl_t3_pontucacao";
            this.lbl_t3_pontucacao.Size = new System.Drawing.Size(99, 23);
            this.lbl_t3_pontucacao.TabIndex = 30;
            this.lbl_t3_pontucacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t3_nome
            // 
            this.lbl_t3_nome.Location = new System.Drawing.Point(71, 154);
            this.lbl_t3_nome.Name = "lbl_t3_nome";
            this.lbl_t3_nome.Size = new System.Drawing.Size(119, 23);
            this.lbl_t3_nome.TabIndex = 29;
            this.lbl_t3_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t2_tempo
            // 
            this.lbl_t2_tempo.Location = new System.Drawing.Point(301, 108);
            this.lbl_t2_tempo.Name = "lbl_t2_tempo";
            this.lbl_t2_tempo.Size = new System.Drawing.Size(98, 23);
            this.lbl_t2_tempo.TabIndex = 28;
            this.lbl_t2_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t2_pontucacao
            // 
            this.lbl_t2_pontucacao.Location = new System.Drawing.Point(196, 108);
            this.lbl_t2_pontucacao.Name = "lbl_t2_pontucacao";
            this.lbl_t2_pontucacao.Size = new System.Drawing.Size(99, 23);
            this.lbl_t2_pontucacao.TabIndex = 27;
            this.lbl_t2_pontucacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t2_nome
            // 
            this.lbl_t2_nome.Location = new System.Drawing.Point(71, 108);
            this.lbl_t2_nome.Name = "lbl_t2_nome";
            this.lbl_t2_nome.Size = new System.Drawing.Size(119, 23);
            this.lbl_t2_nome.TabIndex = 26;
            this.lbl_t2_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t1_tempo
            // 
            this.lbl_t1_tempo.Location = new System.Drawing.Point(301, 62);
            this.lbl_t1_tempo.Name = "lbl_t1_tempo";
            this.lbl_t1_tempo.Size = new System.Drawing.Size(98, 23);
            this.lbl_t1_tempo.TabIndex = 25;
            this.lbl_t1_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t1_pontucacao
            // 
            this.lbl_t1_pontucacao.Location = new System.Drawing.Point(196, 62);
            this.lbl_t1_pontucacao.Name = "lbl_t1_pontucacao";
            this.lbl_t1_pontucacao.Size = new System.Drawing.Size(99, 23);
            this.lbl_t1_pontucacao.TabIndex = 24;
            this.lbl_t1_pontucacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t1_nome
            // 
            this.lbl_t1_nome.Location = new System.Drawing.Point(71, 62);
            this.lbl_t1_nome.Name = "lbl_t1_nome";
            this.lbl_t1_nome.Size = new System.Drawing.Size(119, 23);
            this.lbl_t1_nome.TabIndex = 23;
            this.lbl_t1_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(302, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tempo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(196, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pontuação";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(71, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.BackColor = System.Drawing.Color.Transparent;
            this.final.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(618, 282);
            this.final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(0, 38);
            this.final.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::MineSweeper.Properties.Resources.background4;
            this.ClientSize = new System.Drawing.Size(1012, 407);
            this.Controls.Add(this.final);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_jogador);
            this.Controls.Add(this.gb_dificuldade);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_focus);
            this.Controls.Add(this.lbl_pontuacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Comecar);
            this.Controls.Add(this.flp_campo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campo Minado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_dificuldade.ResumeLayout(false);
            this.gb_dificuldade.PerformLayout();
            this.gb_jogador.ResumeLayout(false);
            this.gb_jogador.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_campo;
        private System.Windows.Forms.Button btn_Comecar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pontuacao;
        private System.Windows.Forms.Button btn_focus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Timer tmr_pontuacao_tempo;
        private System.Windows.Forms.GroupBox gb_dificuldade;
        private System.Windows.Forms.RadioButton rb_dif_impossivel;
        private System.Windows.Forms.RadioButton rb_dif_extremo;
        private System.Windows.Forms.RadioButton rb_dif_dificil;
        private System.Windows.Forms.RadioButton rb_dif_medio;
        private System.Windows.Forms.RadioButton rb_dif_facil;
        private System.Windows.Forms.GroupBox gb_jogador;
        private System.Windows.Forms.TextBox txb_jog_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_t3_tempo;
        private System.Windows.Forms.Label lbl_t3_pontucacao;
        private System.Windows.Forms.Label lbl_t3_nome;
        private System.Windows.Forms.Label lbl_t2_tempo;
        private System.Windows.Forms.Label lbl_t2_pontucacao;
        private System.Windows.Forms.Label lbl_t2_nome;
        private System.Windows.Forms.Label lbl_t1_tempo;
        private System.Windows.Forms.Label lbl_t1_pontucacao;
        private System.Windows.Forms.Label lbl_t1_nome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label final;
    }
}

