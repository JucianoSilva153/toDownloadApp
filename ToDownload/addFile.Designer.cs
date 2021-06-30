namespace ToDownload
{
    partial class addFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFile));
            this.txt_nome = new Guna.UI.WinForms.GunaLineTextBox();
            this.cb_tipo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbtn_alta = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.lbl_alta = new Guna.UI.WinForms.GunaLabel();
            this.rbtn_media = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.rbtn_baixa = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbtn_nao = new Guna.UI.WinForms.GunaLabel();
            this.gunaMediumRadioButton2 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.rbtn_sim = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.btn_adicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nome.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.txt_nome.Location = new System.Drawing.Point(23, 110);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(254, 33);
            this.txt_nome.TabIndex = 0;
            // 
            // cb_tipo
            // 
            this.cb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.cb_tipo.BaseColor = System.Drawing.Color.White;
            this.cb_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.cb_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FocusedColor = System.Drawing.Color.Empty;
            this.cb_tipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_tipo.ForeColor = System.Drawing.Color.Black;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Tipo de Aqruivo",
            "Multimédia",
            "App(Desktop)",
            "App(Mobile)",
            "Jogo(Desktop)",
            "Jogo(Mobile)",
            "Documento",
            "Outro"});
            this.cb_tipo.Location = new System.Drawing.Point(308, 117);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.cb_tipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_tipo.Size = new System.Drawing.Size(254, 26);
            this.cb_tipo.StartIndex = 0;
            this.cb_tipo.TabIndex = 1;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.rbtn_baixa);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.rbtn_media);
            this.gunaGroupBox1.Controls.Add(this.lbl_alta);
            this.gunaGroupBox1.Controls.Add(this.rbtn_alta);
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(17, 173);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(260, 94);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.Text = "Prioridade";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbtn_alta
            // 
            this.rbtn_alta.BaseColor = System.Drawing.Color.White;
            this.rbtn_alta.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.rbtn_alta.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.rbtn_alta.FillColor = System.Drawing.Color.White;
            this.rbtn_alta.Location = new System.Drawing.Point(7, 52);
            this.rbtn_alta.Name = "rbtn_alta";
            this.rbtn_alta.Size = new System.Drawing.Size(20, 20);
            this.rbtn_alta.TabIndex = 0;
            this.rbtn_alta.CheckedChanged += new System.EventHandler(this.rbtn_alta_CheckedChanged);
            // 
            // lbl_alta
            // 
            this.lbl_alta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_alta.Location = new System.Drawing.Point(33, 52);
            this.lbl_alta.Name = "lbl_alta";
            this.lbl_alta.Size = new System.Drawing.Size(36, 20);
            this.lbl_alta.TabIndex = 1;
            this.lbl_alta.Text = "Alta";
            this.lbl_alta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_media
            // 
            this.rbtn_media.BaseColor = System.Drawing.Color.White;
            this.rbtn_media.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.rbtn_media.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.rbtn_media.FillColor = System.Drawing.Color.White;
            this.rbtn_media.Location = new System.Drawing.Point(80, 52);
            this.rbtn_media.Name = "rbtn_media";
            this.rbtn_media.Size = new System.Drawing.Size(20, 20);
            this.rbtn_media.TabIndex = 0;
            this.rbtn_media.CheckedChanged += new System.EventHandler(this.rbtn_media_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(106, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Média";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_baixa
            // 
            this.rbtn_baixa.BaseColor = System.Drawing.Color.White;
            this.rbtn_baixa.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.rbtn_baixa.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.rbtn_baixa.FillColor = System.Drawing.Color.White;
            this.rbtn_baixa.Location = new System.Drawing.Point(169, 52);
            this.rbtn_baixa.Name = "rbtn_baixa";
            this.rbtn_baixa.Size = new System.Drawing.Size(20, 20);
            this.rbtn_baixa.TabIndex = 0;
            this.rbtn_baixa.CheckedChanged += new System.EventHandler(this.rbtn_baixa_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(195, 52);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Baixa";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.rbtn_nao);
            this.gunaGroupBox2.Controls.Add(this.gunaMediumRadioButton2);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Controls.Add(this.rbtn_sim);
            this.gunaGroupBox2.LineBottom = 1;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.gunaGroupBox2.LineLeft = 1;
            this.gunaGroupBox2.LineRight = 1;
            this.gunaGroupBox2.Location = new System.Drawing.Point(308, 173);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(162, 94);
            this.gunaGroupBox2.TabIndex = 3;
            this.gunaGroupBox2.Text = "Baixado?";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbtn_nao
            // 
            this.rbtn_nao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtn_nao.Location = new System.Drawing.Point(106, 52);
            this.rbtn_nao.Name = "rbtn_nao";
            this.rbtn_nao.Size = new System.Drawing.Size(44, 20);
            this.rbtn_nao.TabIndex = 1;
            this.rbtn_nao.Text = "Não";
            this.rbtn_nao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaMediumRadioButton2
            // 
            this.gunaMediumRadioButton2.BaseColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton2.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.gunaMediumRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.gunaMediumRadioButton2.FillColor = System.Drawing.Color.White;
            this.gunaMediumRadioButton2.Location = new System.Drawing.Point(80, 52);
            this.gunaMediumRadioButton2.Name = "gunaMediumRadioButton2";
            this.gunaMediumRadioButton2.Size = new System.Drawing.Size(20, 20);
            this.gunaMediumRadioButton2.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(33, 52);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(36, 20);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Sim";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_sim
            // 
            this.rbtn_sim.BaseColor = System.Drawing.Color.White;
            this.rbtn_sim.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.rbtn_sim.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.rbtn_sim.FillColor = System.Drawing.Color.White;
            this.rbtn_sim.Location = new System.Drawing.Point(7, 52);
            this.rbtn_sim.Name = "rbtn_sim";
            this.rbtn_sim.Size = new System.Drawing.Size(20, 20);
            this.rbtn_sim.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.ActiveBorderThickness = 1;
            this.btn_adicionar.ActiveCornerRadius = 20;
            this.btn_adicionar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.btn_adicionar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_adicionar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.ButtonText = "Adicionar";
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_adicionar.IdleBorderThickness = 1;
            this.btn_adicionar.IdleCornerRadius = 20;
            this.btn_adicionar.IdleFillColor = System.Drawing.Color.White;
            this.btn_adicionar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_adicionar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_adicionar.Location = new System.Drawing.Point(82, 289);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(195, 50);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ActiveBorderThickness = 1;
            this.btn_cancelar.ActiveCornerRadius = 20;
            this.btn_cancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.btn_cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(187)))));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_cancelar.IdleBorderThickness = 1;
            this.btn_cancelar.IdleCornerRadius = 20;
            this.btn_cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_cancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_cancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(218)))), ((int)(((byte)(235)))));
            this.btn_cancelar.Location = new System.Drawing.Point(287, 289);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(195, 50);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 364);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.txt_nome);
            this.Name = "addFile";
            this.Text = "Adicionar Arquivo para Download";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txt_nome;
        private Guna.UI.WinForms.GunaComboBox cb_tipo;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_baixa;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_media;
        private Guna.UI.WinForms.GunaLabel lbl_alta;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_alta;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel rbtn_nao;
        private Guna.UI.WinForms.GunaMediumRadioButton gunaMediumRadioButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_sim;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_adicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
    }
}