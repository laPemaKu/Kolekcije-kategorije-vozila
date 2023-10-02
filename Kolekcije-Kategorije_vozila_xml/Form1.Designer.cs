namespace Kolekcije_Kategorije_vozila_xml
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnispis = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUDbrojkotaca = new System.Windows.Forms.NumericUpDown();
            this.comGodine = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDbrojkotaca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(28, 52);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 0;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(38, 267);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 3;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(38, 307);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(75, 23);
            this.btnObrada.TabIndex = 4;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnispis
            // 
            this.btnispis.Location = new System.Drawing.Point(38, 351);
            this.btnispis.Name = "btnispis";
            this.btnispis.Size = new System.Drawing.Size(75, 23);
            this.btnispis.TabIndex = 5;
            this.btnispis.Text = "Ispis";
            this.btnispis.UseVisualStyleBackColor = true;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(160, 24);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(565, 353);
            this.txtIspis.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj kotača:";
            // 
            // numUDbrojkotaca
            // 
            this.numUDbrojkotaca.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUDbrojkotaca.Location = new System.Drawing.Point(28, 169);
            this.numUDbrojkotaca.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUDbrojkotaca.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUDbrojkotaca.Name = "numUDbrojkotaca";
            this.numUDbrojkotaca.Size = new System.Drawing.Size(120, 20);
            this.numUDbrojkotaca.TabIndex = 10;
            this.numUDbrojkotaca.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // comGodine
            // 
            this.comGodine.FormattingEnabled = true;
            this.comGodine.Location = new System.Drawing.Point(27, 109);
            this.comGodine.Name = "comGodine";
            this.comGodine.Size = new System.Drawing.Size(121, 21);
            this.comGodine.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comGodine);
            this.Controls.Add(this.numUDbrojkotaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnispis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Kolekcije";
            ((System.ComponentModel.ISupportInitialize)(this.numUDbrojkotaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnispis;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUDbrojkotaca;
        private System.Windows.Forms.ComboBox comGodine;
    }
}

