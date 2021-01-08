namespace SeloEletronicoAM.WinForms.Forms
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.fbd_SaveFile = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_AbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.txtAbrirArquivo1 = new System.Windows.Forms.TextBox();
            this.btn_abrirArquivo1 = new System.Windows.Forms.Button();
            this.rb_ImportarCsvSeladora = new System.Windows.Forms.RadioButton();
            this.txtSalvarArquivo1 = new System.Windows.Forms.TextBox();
            this.btn_SalvarArquivo1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.rbCompararSelosSalvarJson = new System.Windows.Forms.RadioButton();
            this.rbCompararSelosSalvarCsv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLerResumoArquivo = new System.Windows.Forms.RadioButton();
            this.btn_abrirArquivo2 = new System.Windows.Forms.Button();
            this.txtAbrirArquivo2 = new System.Windows.Forms.TextBox();
            this.btnScriptSql = new System.Windows.Forms.Button();
            this.cmbOrigem1 = new System.Windows.Forms.ComboBox();
            this.cmbOrigem2 = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkEmolumentos = new System.Windows.Forms.CheckBox();
            this.chkComputacao = new System.Windows.Forms.CheckBox();
            this.chkNotificacao = new System.Windows.Forms.CheckBox();
            this.chkSelo = new System.Windows.Forms.CheckBox();
            this.chkFExtrajudicial = new System.Windows.Forms.CheckBox();
            this.chkISSQN = new System.Windows.Forms.CheckBox();
            this.chkFunetj = new System.Windows.Forms.CheckBox();
            this.chkFRcnpsd = new System.Windows.Forms.CheckBox();
            this.chkFundpam = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisador de Selos - AM";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(195, 510);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(163, 36);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Importar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ofd_AbrirArquivo
            // 
            this.ofd_AbrirArquivo.FileName = "openFileDialog1";
            // 
            // txtAbrirArquivo1
            // 
            this.txtAbrirArquivo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbrirArquivo1.Location = new System.Drawing.Point(15, 35);
            this.txtAbrirArquivo1.Name = "txtAbrirArquivo1";
            this.txtAbrirArquivo1.Size = new System.Drawing.Size(341, 27);
            this.txtAbrirArquivo1.TabIndex = 2;
            // 
            // btn_abrirArquivo1
            // 
            this.btn_abrirArquivo1.Location = new System.Drawing.Point(364, 35);
            this.btn_abrirArquivo1.Name = "btn_abrirArquivo1";
            this.btn_abrirArquivo1.Size = new System.Drawing.Size(38, 27);
            this.btn_abrirArquivo1.TabIndex = 3;
            this.btn_abrirArquivo1.Text = "...";
            this.btn_abrirArquivo1.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo1.Click += new System.EventHandler(this.btn_abrirArquivo1_Click);
            // 
            // rb_ImportarCsvSeladora
            // 
            this.rb_ImportarCsvSeladora.AutoSize = true;
            this.rb_ImportarCsvSeladora.Checked = true;
            this.rb_ImportarCsvSeladora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_ImportarCsvSeladora.Location = new System.Drawing.Point(24, 27);
            this.rb_ImportarCsvSeladora.Name = "rb_ImportarCsvSeladora";
            this.rb_ImportarCsvSeladora.Size = new System.Drawing.Size(204, 24);
            this.rb_ImportarCsvSeladora.TabIndex = 5;
            this.rb_ImportarCsvSeladora.TabStop = true;
            this.rb_ImportarCsvSeladora.Text = "Importar selos da seladora";
            this.rb_ImportarCsvSeladora.UseVisualStyleBackColor = true;
            // 
            // txtSalvarArquivo1
            // 
            this.txtSalvarArquivo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalvarArquivo1.Location = new System.Drawing.Point(14, 35);
            this.txtSalvarArquivo1.Name = "txtSalvarArquivo1";
            this.txtSalvarArquivo1.Size = new System.Drawing.Size(349, 27);
            this.txtSalvarArquivo1.TabIndex = 2;
            // 
            // btn_SalvarArquivo1
            // 
            this.btn_SalvarArquivo1.Location = new System.Drawing.Point(378, 35);
            this.btn_SalvarArquivo1.Name = "btn_SalvarArquivo1";
            this.btn_SalvarArquivo1.Size = new System.Drawing.Size(38, 27);
            this.btn_SalvarArquivo1.TabIndex = 3;
            this.btn_SalvarArquivo1.Text = "...";
            this.btn_SalvarArquivo1.UseVisualStyleBackColor = true;
            this.btn_SalvarArquivo1.Click += new System.EventHandler(this.btn_SalvarArquivo1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(614, 25);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(340, 615);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.Text = "";
            // 
            // rbCompararSelosSalvarJson
            // 
            this.rbCompararSelosSalvarJson.AutoSize = true;
            this.rbCompararSelosSalvarJson.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCompararSelosSalvarJson.Location = new System.Drawing.Point(244, 64);
            this.rbCompararSelosSalvarJson.Name = "rbCompararSelosSalvarJson";
            this.rbCompararSelosSalvarJson.Size = new System.Drawing.Size(314, 24);
            this.rbCompararSelosSalvarJson.TabIndex = 7;
            this.rbCompararSelosSalvarJson.Text = "Comparar selos (Salvar resultado em JSON)";
            this.rbCompararSelosSalvarJson.UseVisualStyleBackColor = true;
            this.rbCompararSelosSalvarJson.CheckedChanged += new System.EventHandler(this.AjustarVisualizacaoFormulario);
            // 
            // rbCompararSelosSalvarCsv
            // 
            this.rbCompararSelosSalvarCsv.AutoSize = true;
            this.rbCompararSelosSalvarCsv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCompararSelosSalvarCsv.Location = new System.Drawing.Point(244, 27);
            this.rbCompararSelosSalvarCsv.Name = "rbCompararSelosSalvarCsv";
            this.rbCompararSelosSalvarCsv.Size = new System.Drawing.Size(305, 24);
            this.rbCompararSelosSalvarCsv.TabIndex = 8;
            this.rbCompararSelosSalvarCsv.Text = "Comparar selos (Salvar resultado em CSV)";
            this.rbCompararSelosSalvarCsv.UseVisualStyleBackColor = true;
            this.rbCompararSelosSalvarCsv.CheckedChanged += new System.EventHandler(this.AjustarVisualizacaoFormulario);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.rbLerResumoArquivo);
            this.groupBox1.Controls.Add(this.rbCompararSelosSalvarCsv);
            this.groupBox1.Controls.Add(this.rbCompararSelosSalvarJson);
            this.groupBox1.Controls.Add(this.rb_ImportarCsvSeladora);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ação";
            // 
            // rbLerResumoArquivo
            // 
            this.rbLerResumoArquivo.AutoSize = true;
            this.rbLerResumoArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLerResumoArquivo.Location = new System.Drawing.Point(24, 64);
            this.rbLerResumoArquivo.Name = "rbLerResumoArquivo";
            this.rbLerResumoArquivo.Size = new System.Drawing.Size(183, 24);
            this.rbLerResumoArquivo.TabIndex = 5;
            this.rbLerResumoArquivo.Text = "Resumo e totalizadores";
            this.rbLerResumoArquivo.UseVisualStyleBackColor = true;
            this.rbLerResumoArquivo.CheckedChanged += new System.EventHandler(this.AjustarVisualizacaoFormulario);
            // 
            // btn_abrirArquivo2
            // 
            this.btn_abrirArquivo2.Location = new System.Drawing.Point(363, 38);
            this.btn_abrirArquivo2.Name = "btn_abrirArquivo2";
            this.btn_abrirArquivo2.Size = new System.Drawing.Size(38, 27);
            this.btn_abrirArquivo2.TabIndex = 3;
            this.btn_abrirArquivo2.Text = "...";
            this.btn_abrirArquivo2.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo2.Click += new System.EventHandler(this.btn_abrirArquivo2_Click);
            // 
            // txtAbrirArquivo2
            // 
            this.txtAbrirArquivo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbrirArquivo2.Location = new System.Drawing.Point(14, 39);
            this.txtAbrirArquivo2.Name = "txtAbrirArquivo2";
            this.txtAbrirArquivo2.Size = new System.Drawing.Size(341, 27);
            this.txtAbrirArquivo2.TabIndex = 2;
            // 
            // btnScriptSql
            // 
            this.btnScriptSql.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnScriptSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScriptSql.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptSql.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptSql.Location = new System.Drawing.Point(12, 529);
            this.btnScriptSql.Name = "btnScriptSql";
            this.btnScriptSql.Size = new System.Drawing.Size(112, 36);
            this.btnScriptSql.TabIndex = 10;
            this.btnScriptSql.Text = "Script SQL";
            this.btnScriptSql.UseVisualStyleBackColor = false;
            this.btnScriptSql.Click += new System.EventHandler(this.btnScriptSql_Click);
            // 
            // cmbOrigem1
            // 
            this.cmbOrigem1.FormattingEnabled = true;
            this.cmbOrigem1.Items.AddRange(new object[] {
            "",
            "Cartório",
            "Tribunal"});
            this.cmbOrigem1.Location = new System.Drawing.Point(420, 34);
            this.cmbOrigem1.Name = "cmbOrigem1";
            this.cmbOrigem1.Size = new System.Drawing.Size(121, 28);
            this.cmbOrigem1.TabIndex = 11;
            // 
            // cmbOrigem2
            // 
            this.cmbOrigem2.FormattingEnabled = true;
            this.cmbOrigem2.Items.AddRange(new object[] {
            "",
            "Cartório",
            "Tribunal"});
            this.cmbOrigem2.Location = new System.Drawing.Point(416, 38);
            this.cmbOrigem2.Name = "cmbOrigem2";
            this.cmbOrigem2.Size = new System.Drawing.Size(121, 28);
            this.cmbOrigem2.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(614, 659);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 23);
            this.progressBar.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txtAbrirArquivo1);
            this.groupBox2.Controls.Add(this.btn_abrirArquivo1);
            this.groupBox2.Controls.Add(this.cmbOrigem1);
            this.groupBox2.Location = new System.Drawing.Point(24, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abrir arquivo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.txtAbrirArquivo2);
            this.groupBox3.Controls.Add(this.btn_abrirArquivo2);
            this.groupBox3.Controls.Add(this.cmbOrigem2);
            this.groupBox3.Location = new System.Drawing.Point(24, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 82);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abrir arquivo";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Wheat;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.txtSalvarArquivo1);
            this.groupBox4.Controls.Add(this.btn_SalvarArquivo1);
            this.groupBox4.Location = new System.Drawing.Point(24, 408);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 82);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salvar arquivo";
            // 
            // chkEmolumentos
            // 
            this.chkEmolumentos.AutoSize = true;
            this.chkEmolumentos.Location = new System.Drawing.Point(32, 609);
            this.chkEmolumentos.Name = "chkEmolumentos";
            this.chkEmolumentos.Size = new System.Drawing.Size(119, 24);
            this.chkEmolumentos.TabIndex = 17;
            this.chkEmolumentos.Text = "Emolumentos";
            this.chkEmolumentos.UseVisualStyleBackColor = true;
            // 
            // chkComputacao
            // 
            this.chkComputacao.AutoSize = true;
            this.chkComputacao.Location = new System.Drawing.Point(166, 609);
            this.chkComputacao.Name = "chkComputacao";
            this.chkComputacao.Size = new System.Drawing.Size(113, 24);
            this.chkComputacao.TabIndex = 18;
            this.chkComputacao.Text = "Computação";
            this.chkComputacao.UseVisualStyleBackColor = true;
            // 
            // chkNotificacao
            // 
            this.chkNotificacao.AutoSize = true;
            this.chkNotificacao.Location = new System.Drawing.Point(294, 609);
            this.chkNotificacao.Name = "chkNotificacao";
            this.chkNotificacao.Size = new System.Drawing.Size(105, 24);
            this.chkNotificacao.TabIndex = 19;
            this.chkNotificacao.Text = "Notificação";
            this.chkNotificacao.UseVisualStyleBackColor = true;
            // 
            // chkSelo
            // 
            this.chkSelo.AutoSize = true;
            this.chkSelo.Location = new System.Drawing.Point(414, 609);
            this.chkSelo.Name = "chkSelo";
            this.chkSelo.Size = new System.Drawing.Size(57, 24);
            this.chkSelo.TabIndex = 20;
            this.chkSelo.Text = "Selo";
            this.chkSelo.UseVisualStyleBackColor = true;
            // 
            // chkFExtrajudicial
            // 
            this.chkFExtrajudicial.AutoSize = true;
            this.chkFExtrajudicial.Location = new System.Drawing.Point(33, 651);
            this.chkFExtrajudicial.Name = "chkFExtrajudicial";
            this.chkFExtrajudicial.Size = new System.Drawing.Size(123, 24);
            this.chkFExtrajudicial.TabIndex = 21;
            this.chkFExtrajudicial.Text = "F. Extrajudicial";
            this.chkFExtrajudicial.UseVisualStyleBackColor = true;
            // 
            // chkISSQN
            // 
            this.chkISSQN.AutoSize = true;
            this.chkISSQN.Location = new System.Drawing.Point(501, 609);
            this.chkISSQN.Name = "chkISSQN";
            this.chkISSQN.Size = new System.Drawing.Size(70, 24);
            this.chkISSQN.TabIndex = 22;
            this.chkISSQN.Text = "ISSQN";
            this.chkISSQN.UseVisualStyleBackColor = true;
            // 
            // chkFunetj
            // 
            this.chkFunetj.AutoSize = true;
            this.chkFunetj.Location = new System.Drawing.Point(294, 651);
            this.chkFunetj.Name = "chkFunetj";
            this.chkFunetj.Size = new System.Drawing.Size(76, 24);
            this.chkFunetj.TabIndex = 23;
            this.chkFunetj.Text = "FUNETJ";
            this.chkFunetj.UseVisualStyleBackColor = true;
            // 
            // chkFRcnpsd
            // 
            this.chkFRcnpsd.AutoSize = true;
            this.chkFRcnpsd.Location = new System.Drawing.Point(166, 651);
            this.chkFRcnpsd.Name = "chkFRcnpsd";
            this.chkFRcnpsd.Size = new System.Drawing.Size(98, 24);
            this.chkFRcnpsd.TabIndex = 24;
            this.chkFRcnpsd.Text = "F. RCNPSD";
            this.chkFRcnpsd.UseVisualStyleBackColor = true;
            // 
            // chkFundpam
            // 
            this.chkFundpam.AutoSize = true;
            this.chkFundpam.Location = new System.Drawing.Point(414, 651);
            this.chkFundpam.Name = "chkFundpam";
            this.chkFundpam.Size = new System.Drawing.Size(97, 24);
            this.chkFundpam.TabIndex = 25;
            this.chkFundpam.Text = "FUNDPAM";
            this.chkFundpam.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(975, 700);
            this.Controls.Add(this.chkFundpam);
            this.Controls.Add(this.chkFRcnpsd);
            this.Controls.Add(this.chkFunetj);
            this.Controls.Add(this.chkISSQN);
            this.Controls.Add(this.chkFExtrajudicial);
            this.Controls.Add(this.chkSelo);
            this.Controls.Add(this.chkNotificacao);
            this.Controls.Add(this.chkComputacao);
            this.Controls.Add(this.chkEmolumentos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnScriptSql);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.FolderBrowserDialog fbd_SaveFile;
        private System.Windows.Forms.OpenFileDialog ofd_AbrirArquivo;
        private System.Windows.Forms.TextBox txtAbrirArquivo1;
        private System.Windows.Forms.Button btn_abrirArquivo1;
        private System.Windows.Forms.RadioButton rb_ImportarCsvSeladora;
        private System.Windows.Forms.TextBox txtSalvarArquivo1;
        private System.Windows.Forms.Button btn_SalvarArquivo1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RadioButton rbCompararSelosSalvarJson;
        private System.Windows.Forms.RadioButton rbCompararSelosSalvarCsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_abrirArquivo2;
        private System.Windows.Forms.TextBox txtAbrirArquivo2;
        private System.Windows.Forms.Button btnScriptSql;
        private System.Windows.Forms.RadioButton rbLerResumoArquivo;
        private System.Windows.Forms.ComboBox cmbOrigem1;
        private System.Windows.Forms.ComboBox cmbOrigem2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkFundpam;
        private System.Windows.Forms.CheckBox chkFRcnpsd;
        private System.Windows.Forms.CheckBox chkFunetj;
        private System.Windows.Forms.CheckBox chkISSQN;
        private System.Windows.Forms.CheckBox chkFExtrajudicial;
        private System.Windows.Forms.CheckBox chkSelo;
        private System.Windows.Forms.CheckBox chkNotificacao;
        private System.Windows.Forms.CheckBox chkComputacao;
        private System.Windows.Forms.CheckBox chkEmolumentos;
    }
}

