namespace ControleNivel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ve = new System.Windows.Forms.NumericUpDown();
            this.vs = new System.Windows.Forms.NumericUpDown();
            this.tanque1 = new ControleNivel.componentes.Tanque();
            this.valvulaA1 = new ControleNivel.componentes.ValvulaA();
            this.valvulaV1 = new ControleNivel.componentes.ValvulaV();
            this.vz = new System.Windows.Forms.TextBox();
            this.tanque2 = new ControleNivel.componentes.Tanque();
            this.tanque3 = new ControleNivel.componentes.Tanque();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleNivel.Properties.Resources.LEDVDoff;
            this.pictureBox1.Location = new System.Drawing.Point(241, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vazão:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Conectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // ve
            // 
            this.ve.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ve.Location = new System.Drawing.Point(30, 276);
            this.ve.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(71, 20);
            this.ve.TabIndex = 26;
            // 
            // vs
            // 
            this.vs.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vs.Location = new System.Drawing.Point(200, 275);
            this.vs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(71, 20);
            this.vs.TabIndex = 27;
            // 
            // tanque1
            // 
            this.tanque1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tanque1.CorNivel = System.Drawing.Color.BlueViolet;
            this.tanque1.Location = new System.Drawing.Point(12, 59);
            this.tanque1.Name = "tanque1";
            this.tanque1.Nivel = 0D;
            this.tanque1.NivelMax = 300D;
            this.tanque1.NivelMin = 0D;
            this.tanque1.NomeTanque = "Nome Tanque";
            this.tanque1.Size = new System.Drawing.Size(89, 117);
            this.tanque1.TabIndex = 11;
            // 
            // valvulaA1
            // 
            this.valvulaA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valvulaA1.Location = new System.Drawing.Point(24, 182);
            this.valvulaA1.Name = "valvulaA1";
            this.valvulaA1.Nome = "Válvula";
            this.valvulaA1.Size = new System.Drawing.Size(77, 84);
            this.valvulaA1.Status = true;
            this.valvulaA1.TabIndex = 12;
            // 
            // valvulaV1
            // 
            this.valvulaV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valvulaV1.Location = new System.Drawing.Point(190, 181);
            this.valvulaV1.Name = "valvulaV1";
            this.valvulaV1.Nome = "Válvula";
            this.valvulaV1.Size = new System.Drawing.Size(81, 88);
            this.valvulaV1.Status = true;
            this.valvulaV1.TabIndex = 13;
            // 
            // vz
            // 
            this.vz.Enabled = false;
            this.vz.Location = new System.Drawing.Point(119, 308);
            this.vz.Name = "vz";
            this.vz.Size = new System.Drawing.Size(100, 20);
            this.vz.TabIndex = 28;
            // 
            // tanque2
            // 
            this.tanque2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tanque2.CorNivel = System.Drawing.Color.BlueViolet;
            this.tanque2.Location = new System.Drawing.Point(107, 60);
            this.tanque2.Name = "tanque2";
            this.tanque2.Nivel = 0D;
            this.tanque2.NivelMax = 300D;
            this.tanque2.NivelMin = 0D;
            this.tanque2.NomeTanque = "Nome Tanque";
            this.tanque2.Size = new System.Drawing.Size(89, 117);
            this.tanque2.TabIndex = 11;
            // 
            // tanque3
            // 
            this.tanque3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tanque3.CorNivel = System.Drawing.Color.BlueViolet;
            this.tanque3.Location = new System.Drawing.Point(201, 61);
            this.tanque3.Name = "tanque3";
            this.tanque3.Nivel = 0D;
            this.tanque3.NivelMax = 300D;
            this.tanque3.NivelMin = 0D;
            this.tanque3.NomeTanque = "Nome Tanque";
            this.tanque3.Size = new System.Drawing.Size(89, 117);
            this.tanque3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 347);
            this.Controls.Add(this.vz);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.ve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tanque3);
            this.Controls.Add(this.tanque2);
            this.Controls.Add(this.tanque1);
            this.Controls.Add(this.valvulaA1);
            this.Controls.Add(this.valvulaV1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private componentes.Tanque tanque1;
        private componentes.ValvulaA valvulaA1;
        private componentes.ValvulaV valvulaV1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ve;
        private System.Windows.Forms.NumericUpDown vs;
        private System.Windows.Forms.TextBox vz;
        private componentes.Tanque tanque2;
        private componentes.Tanque tanque3;
    }
}

