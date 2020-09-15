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
            this.btn_abrirArquivo2 = new System.Windows.Forms.Button();
            this.lbl_AbrirArquivo2 = new System.Windows.Forms.Label();
            this.txtAbrirArquivo2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisador de Selos - AM";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.txtAbrirArquivo1.Location = new System.Drawing.Point(28, 230);
            this.txtAbrirArquivo1.Name = "txtAbrirArquivo1";
            this.txtAbrirArquivo1.Size = new System.Drawing.Size(551, 23);
            this.txtAbrirArquivo1.TabIndex = 2;
            // 
            // btn_abrirArquivo1
            // 
            this.btn_abrirArquivo1.Location = new System.Drawing.Point(585, 230);
            this.btn_abrirArquivo1.Name = "btn_abrirArquivo1";
            this.btn_abrirArquivo1.Size = new System.Drawing.Size(38, 23);
            this.btn_abrirArquivo1.TabIndex = 3;
            this.btn_abrirArquivo1.Text = "...";
            this.btn_abrirArquivo1.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo1.Click += new System.EventHandler(this.btn_abrirArquivo1_Click);
            // 
            // lbl_AbrirArquivo1
            // 
            this.lbl_AbrirArquivo1.AutoSize = true;
            this.lbl_AbrirArquivo1.Location = new System.Drawing.Point(28, 201);
            this.lbl_AbrirArquivo1.Name = "lbl_AbrirArquivo1";
            this.lbl_AbrirArquivo1.Size = new System.Drawing.Size(76, 15);
            this.lbl_AbrirArquivo1.TabIndex = 4;
            this.lbl_AbrirArquivo1.Text = "Abrir arquivo";
            // 
            // rb_ImportarCsvSeladora
            // 
            this.rb_ImportarCsvSeladora.AutoSize = true;
            this.rb_ImportarCsvSeladora.Checked = true;
            this.rb_ImportarCsvSeladora.Location = new System.Drawing.Point(26, 42);
            this.rb_ImportarCsvSeladora.Name = "rb_ImportarCsvSeladora";
            this.rb_ImportarCsvSeladora.Size = new System.Drawing.Size(163, 19);
            this.rb_ImportarCsvSeladora.TabIndex = 5;
            this.rb_ImportarCsvSeladora.TabStop = true;
            this.rb_ImportarCsvSeladora.Text = "Importar selos da seladora";
            this.rb_ImportarCsvSeladora.UseVisualStyleBackColor = true;
            // 
            // txtSalvarArquivo1
            // 
            this.txtSalvarArquivo1.Location = new System.Drawing.Point(28, 363);
            this.txtSalvarArquivo1.Name = "txtSalvarArquivo1";
            this.txtSalvarArquivo1.Size = new System.Drawing.Size(551, 23);
            this.txtSalvarArquivo1.TabIndex = 2;
            // 
            // btn_SalvarArquivo1
            // 
            this.btn_SalvarArquivo1.Location = new System.Drawing.Point(585, 363);
            this.btn_SalvarArquivo1.Name = "btn_SalvarArquivo1";
            this.btn_SalvarArquivo1.Size = new System.Drawing.Size(38, 23);
            this.btn_SalvarArquivo1.TabIndex = 3;
            this.btn_SalvarArquivo1.Text = "...";
            this.btn_SalvarArquivo1.UseVisualStyleBackColor = true;
            this.btn_SalvarArquivo1.Click += new System.EventHandler(this.btn_SalvarArquivo1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salvar arquivo";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(33, 443);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(595, 161);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.Text = "";
            // 
            // rbCompararSelosSalvarJson
            // 
            this.rbCompararSelosSalvarJson.AutoSize = true;
            this.rbCompararSelosSalvarJson.Location = new System.Drawing.Point(244, 64);
            this.rbCompararSelosSalvarJson.Name = "rbCompararSelosSalvarJson";
            this.rbCompararSelosSalvarJson.Size = new System.Drawing.Size(252, 19);
            this.rbCompararSelosSalvarJson.TabIndex = 7;
            this.rbCompararSelosSalvarJson.Text = "Comparar selos (Salvar resultado em JSON)";
            this.rbCompararSelosSalvarJson.UseVisualStyleBackColor = true;
            this.rbCompararSelosSalvarJson.CheckedChanged += new System.EventHandler(this.form1_Load);
            // 
            // rbCompararSelosSalvarCsv
            // 
            this.rbCompararSelosSalvarCsv.AutoSize = true;
            this.rbCompararSelosSalvarCsv.Location = new System.Drawing.Point(244, 27);
            this.rbCompararSelosSalvarCsv.Name = "rbCompararSelosSalvarCsv";
            this.rbCompararSelosSalvarCsv.Size = new System.Drawing.Size(245, 19);
            this.rbCompararSelosSalvarCsv.TabIndex = 8;
            this.rbCompararSelosSalvarCsv.Text = "Comparar selos (Salvar resultado em CSV)";
            this.rbCompararSelosSalvarCsv.UseVisualStyleBackColor = true;
            this.rbCompararSelosSalvarCsv.CheckedChanged += new System.EventHandler(this.form1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCompararSelosSalvarCsv);
            this.groupBox1.Controls.Add(this.rbCompararSelosSalvarJson);
            this.groupBox1.Controls.Add(this.rb_ImportarCsvSeladora);
            this.groupBox1.Location = new System.Drawing.Point(73, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ação";
            // 
            // btn_abrirArquivo2
            // 
            this.btn_abrirArquivo2.Location = new System.Drawing.Point(585, 297);
            this.btn_abrirArquivo2.Name = "btn_abrirArquivo2";
            this.btn_abrirArquivo2.Size = new System.Drawing.Size(38, 23);
            this.btn_abrirArquivo2.TabIndex = 3;
            this.btn_abrirArquivo2.Text = "...";
            this.btn_abrirArquivo2.UseVisualStyleBackColor = true;
            this.btn_abrirArquivo2.Click += new System.EventHandler(this.btn_abrirArquivo2_Click);
            // 
            // lbl_AbrirArquivo2
            // 
            this.lbl_AbrirArquivo2.AutoSize = true;
            this.lbl_AbrirArquivo2.Location = new System.Drawing.Point(28, 268);
            this.lbl_AbrirArquivo2.Name = "lbl_AbrirArquivo2";
            this.lbl_AbrirArquivo2.Size = new System.Drawing.Size(76, 15);
            this.lbl_AbrirArquivo2.TabIndex = 4;
            this.lbl_AbrirArquivo2.Text = "Abrir arquivo";
            // 
            // txtAbrirArquivo2
            // 
            this.txtAbrirArquivo2.Location = new System.Drawing.Point(28, 297);
            this.txtAbrirArquivo2.Name = "txtAbrirArquivo2";
            this.txtAbrirArquivo2.Size = new System.Drawing.Size(551, 23);
            this.txtAbrirArquivo2.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 635);
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
    }
}

