namespace Base64App
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
            this.txtInputTekst = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.txtOutputTekst = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbZgjedhDekodo = new System.Windows.Forms.RadioButton();
            this.rdbZgjedhKodo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbShkruajTekst = new System.Windows.Forms.RadioButton();
            this.rdbImportTekst = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTekstiJuaj = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputTekst
            // 
            this.txtInputTekst.BackColor = System.Drawing.Color.MintCream;
            this.txtInputTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtInputTekst.Location = new System.Drawing.Point(38, 190);
            this.txtInputTekst.Name = "txtInputTekst";
            this.txtInputTekst.Size = new System.Drawing.Size(389, 28);
            this.txtInputTekst.TabIndex = 3;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Browse.ForeColor = System.Drawing.Color.SeaGreen;
            this.Browse.Location = new System.Drawing.Point(460, 190);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(56, 28);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // txtOutputTekst
            // 
            this.txtOutputTekst.BackColor = System.Drawing.Color.MintCream;
            this.txtOutputTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtOutputTekst.Location = new System.Drawing.Point(40, 531);
            this.txtOutputTekst.Name = "txtOutputTekst";
            this.txtOutputTekst.ReadOnly = true;
            this.txtOutputTekst.Size = new System.Drawing.Size(478, 188);
            this.txtOutputTekst.TabIndex = 5;
            this.txtOutputTekst.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(37, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teksti final:";
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDo.Location = new System.Drawing.Point(40, 739);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(152, 31);
            this.btnDo.TabIndex = 7;
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Location = new System.Drawing.Point(366, 739);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ruaj tekstin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbModiDekripto
            // 
            this.rdbZgjedhDekodo.AutoSize = true;
            this.rdbZgjedhDekodo.Location = new System.Drawing.Point(301, 26);
            this.rdbZgjedhDekodo.Name = "rdbZgjedhDekodo";
            this.rdbZgjedhDekodo.Size = new System.Drawing.Size(100, 28);
            this.rdbZgjedhDekodo.TabIndex = 12;
            this.rdbZgjedhDekodo.Text = "Dekodo";
            this.rdbZgjedhDekodo.UseVisualStyleBackColor = true;
            this.rdbZgjedhDekodo.CheckedChanged += new System.EventHandler(this.rdbZgjedhDekodo_CheckedChanged);
            // 
            // rdbModiKodo
            // 
            this.rdbZgjedhKodo.AutoSize = true;
            this.rdbZgjedhKodo.Location = new System.Drawing.Point(70, 27);
            this.rdbZgjedhKodo.Name = "rdbZgjedhKodo";
            this.rdbZgjedhKodo.Size = new System.Drawing.Size(100, 28);
            this.rdbZgjedhKodo.TabIndex = 11;
            this.rdbZgjedhKodo.Text = "Kodo";
            this.rdbZgjedhKodo.UseVisualStyleBackColor = true;
            this.rdbZgjedhKodo.CheckedChanged += new System.EventHandler(this.rdbZgjedhKodo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbZgjedhKodo);
            this.groupBox1.Controls.Add(this.rdbZgjedhDekodo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(38, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zgjedh: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbShkruajTekst);
            this.groupBox2.Controls.Add(this.rdbImportTekst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(38, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 60);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma: ";
            // 
            // rdbShkruajTekst
            // 
            this.rdbShkruajTekst.AutoSize = true;
            this.rdbShkruajTekst.Location = new System.Drawing.Point(301, 26);
            this.rdbShkruajTekst.Name = "rdbShkruajTekst";
            this.rdbShkruajTekst.Size = new System.Drawing.Size(144, 28);
            this.rdbShkruajTekst.TabIndex = 11;
            this.rdbShkruajTekst.Text = "Shkruaj Tekst";
            this.rdbShkruajTekst.UseVisualStyleBackColor = true;
            this.rdbShkruajTekst.CheckedChanged += new System.EventHandler(this.rdbShkruajTekst_CheckedChanged);
            // 
            // rdbImportTekst
            // 
            this.rdbImportTekst.AutoSize = true;
            this.rdbImportTekst.Location = new System.Drawing.Point(70, 26);
            this.rdbImportTekst.Name = "rdbImportTekst";
            this.rdbImportTekst.Size = new System.Drawing.Size(144, 28);
            this.rdbImportTekst.TabIndex = 12;
            this.rdbImportTekst.Text = "Importo Tekst";
            this.rdbImportTekst.UseVisualStyleBackColor = true;
            this.rdbImportTekst.CheckedChanged += new System.EventHandler(this.rdbImportTekst_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(36, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Teksti që keni shkruar: ";
            // 
            // txtTekstiJuaj
            // 
            this.txtTekstiJuaj.BackColor = System.Drawing.Color.MintCream;
            this.txtTekstiJuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTekstiJuaj.Location = new System.Drawing.Point(39, 281);
            this.txtTekstiJuaj.Name = "txtTekstiJuaj";
            this.txtTekstiJuaj.ReadOnly = true;
            this.txtTekstiJuaj.Size = new System.Drawing.Size(478, 188);
            this.txtTekstiJuaj.TabIndex = 15;
            this.txtTekstiJuaj.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(551, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTekstiJuaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputTekst);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.txtInputTekst);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Base64";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInputTekst;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.RichTextBox txtOutputTekst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbZgjedhDekodo;
        private System.Windows.Forms.RadioButton rdbZgjedhKodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbShkruajTekst;
        private System.Windows.Forms.RadioButton rdbImportTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTekstiJuaj;
    }
}

