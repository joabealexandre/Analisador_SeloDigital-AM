namespace SeloEletronicoAM.WinForms
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.fbd_SaveFile = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_AbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.txtAbrirArquivo1 = new System.Windows.Forms.TextBox();
            this.btn_abrirArquivo1 = new System.Windows.Forms.Button();
            this.lbl_AbrirArquivo1 = new System.Windows.Forms.Label();
            this.rb_ImportarCsvSeladora = new System.Windows.Forms.RadioButton();
            this.txtSalvarArquivo1 = new System.Windows.Forms.TextBox();
            this.btn_SalvarArquivo1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.rbCompararSelosSalvarJson = new System.Windows.Forms.RadioButton();
            this.rbCompararSelosSalvarCsv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLerResumoArquivo = new System.Windows.Forms.RadioButton();
            this.btn_abrirArquivo2 = new System.Windows.Forms.Button();
            this.lbl_AbrirArquivo2 = new System.Windows.Forms.Label();
            this.txtAbrirArquivo2 = new System.Windows.Forms.TextBox();
            this.btnScriptSql = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisador de Selos - AM";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(249, 397);
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
            this.txtAbrirArquivo1.Location = new System.Drawing.Point(28, 230);
            this.txtAbrirArquivo1.Name = "txtAbrirArquivo1";
            this.txtAbrirArquivo1.Size = new System.Drawing.Size(551, 27);
            this.txtAbrirArquivo1.TabIndex = 2;
            // 
            // btn_abrirArquivo1
            // 
            this.btn_abrirArquivo1.Location = new System.Drawing.Point(585, 230);
            this.btn_abrirArquivo1.Name = "btn_abrirArquivo1";
            this.btn_abrirArquivo1.Size = new System.Drawing.Size(38, 27);
            this.btn_abrirArquivo1.TabIndex = 3;
            this.btn_abrirArquivo1.Text = "...";
            this.btn_abrirArquivo1.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo1.Click += new System.EventHandler(this.btn_abrirArquivo1_Click);
            // 
            // lbl_AbrirArquivo1
            // 
            this.lbl_AbrirArquivo1.AutoSize = true;
            this.lbl_AbrirArquivo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AbrirArquivo1.Location = new System.Drawing.Point(28, 201);
            this.lbl_AbrirArquivo1.Name = "lbl_AbrirArquivo1";
            this.lbl_AbrirArquivo1.Size = new System.Drawing.Size(96, 20);
            this.lbl_AbrirArquivo1.TabIndex = 4;
            this.lbl_AbrirArquivo1.Text = "Abrir arquivo";
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
            this.txtSalvarArquivo1.Location = new System.Drawing.Point(28, 363);
            this.txtSalvarArquivo1.Name = "txtSalvarArquivo1";
            this.txtSalvarArquivo1.Size = new System.Drawing.Size(551, 27);
            this.txtSalvarArquivo1.TabIndex = 2;
            // 
            // btn_SalvarArquivo1
            // 
            this.btn_SalvarArquivo1.Location = new System.Drawing.Point(585, 363);
            this.btn_SalvarArquivo1.Name = "btn_SalvarArquivo1";
            this.btn_SalvarArquivo1.Size = new System.Drawing.Size(38, 27);
            this.btn_SalvarArquivo1.TabIndex = 3;
            this.btn_SalvarArquivo1.Text = "...";
            this.btn_SalvarArquivo1.UseVisualStyleBackColor = true;
            this.btn_SalvarArquivo1.Click += new System.EventHandler(this.btn_SalvarArquivo1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salvar arquivo";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(33, 443);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(595, 161);
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
            this.groupBox1.Location = new System.Drawing.Point(45, 67);
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
            this.btn_abrirArquivo2.Location = new System.Drawing.Point(585, 297);
            this.btn_abrirArquivo2.Name = "btn_abrirArquivo2";
            this.btn_abrirArquivo2.Size = new System.Drawing.Size(38, 27);
            this.btn_abrirArquivo2.TabIndex = 3;
            this.btn_abrirArquivo2.Text = "...";
            this.btn_abrirArquivo2.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo2.Click += new System.EventHandler(this.btn_abrirArquivo2_Click);
            // 
            // lbl_AbrirArquivo2
            // 
            this.lbl_AbrirArquivo2.AutoSize = true;
            this.lbl_AbrirArquivo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AbrirArquivo2.Location = new System.Drawing.Point(28, 268);
            this.lbl_AbrirArquivo2.Name = "lbl_AbrirArquivo2";
            this.lbl_AbrirArquivo2.Size = new System.Drawing.Size(108, 20);
            this.lbl_AbrirArquivo2.TabIndex = 4;
            this.lbl_AbrirArquivo2.Text = "Abrir arquivo 2";
            // 
            // txtAbrirArquivo2
            // 
            this.txtAbrirArquivo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbrirArquivo2.Location = new System.Drawing.Point(28, 297);
            this.txtAbrirArquivo2.Name = "txtAbrirArquivo2";
            this.txtAbrirArquivo2.Size = new System.Drawing.Size(551, 27);
            this.txtAbrirArquivo2.TabIndex = 2;
            // 
            // btnScriptSql
            // 
            this.btnScriptSql.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnScriptSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScriptSql.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScriptSql.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScriptSql.Location = new System.Drawing.Point(12, 12);
            this.btnScriptSql.Name = "btnScriptSql";
            this.btnScriptSql.Size = new System.Drawing.Size(112, 36);
            this.btnScriptSql.TabIndex = 10;
            this.btnScriptSql.Text = "Script SQL";
            this.btnScriptSql.UseVisualStyleBackColor = false;
            this.btnScriptSql.Click += new System.EventHandler(this.btnScriptSql_Click);
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(660, 635);
            this.Controls.Add(this.btnScriptSql);
            this.Controls.Add(this.txtAbrirArquivo2);
            this.Controls.Add(this.lbl_AbrirArquivo2);
            this.Controls.Add(this.btn_abrirArquivo2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SalvarArquivo1);
            this.Controls.Add(this.txtSalvarArquivo1);
            this.Controls.Add(this.lbl_AbrirArquivo1);
            this.Controls.Add(this.btn_abrirArquivo1);
            this.Controls.Add(this.txtAbrirArquivo1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisador de Selos - AM";
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_AbrirArquivo1;
        private System.Windows.Forms.RadioButton rb_ImportarCsvSeladora;
        private System.Windows.Forms.TextBox txtSalvarArquivo1;
        private System.Windows.Forms.Button btn_SalvarArquivo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RadioButton rbCompararSelosSalvarJson;
        private System.Windows.Forms.RadioButton rbCompararSelosSalvarCsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_abrirArquivo2;
        private System.Windows.Forms.Label lbl_AbrirArquivo2;
        private System.Windows.Forms.TextBox txtAbrirArquivo2;
        private System.Windows.Forms.Button btnScriptSql;
        private System.Windows.Forms.RadioButton rbLerResumoArquivo;
    }
}

