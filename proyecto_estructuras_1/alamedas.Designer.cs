namespace proyecto_estructuras_1
{
    partial class alamedas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.serv1 = new System.Windows.Forms.CheckBox();
            this.serv2 = new System.Windows.Forms.CheckBox();
            this.serv5 = new System.Windows.Forms.CheckBox();
            this.serv4 = new System.Windows.Forms.CheckBox();
            this.serv3 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serv = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(25, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "ABRIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(486, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(160, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(250, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Marca,
            this.placa});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 303);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(528, 184);
            this.dataGridView2.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // placa
            // 
            this.placa.HeaderText = "placa";
            this.placa.Name = "placa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = " ENVIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "REGISTRO ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // serv1
            // 
            this.serv1.AutoSize = true;
            this.serv1.BackColor = System.Drawing.Color.Transparent;
            this.serv1.Enabled = false;
            this.serv1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv1.Location = new System.Drawing.Point(701, 303);
            this.serv1.Name = "serv1";
            this.serv1.Size = new System.Drawing.Size(172, 21);
            this.serv1.TabIndex = 7;
            this.serv1.Text = "Lavado a Mano Suave";
            this.serv1.UseVisualStyleBackColor = false;
            // 
            // serv2
            // 
            this.serv2.AutoSize = true;
            this.serv2.BackColor = System.Drawing.Color.Transparent;
            this.serv2.Enabled = false;
            this.serv2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv2.Location = new System.Drawing.Point(701, 330);
            this.serv2.Name = "serv2";
            this.serv2.Size = new System.Drawing.Size(134, 21);
            this.serv2.TabIndex = 8;
            this.serv2.Text = "Aspirado Interior";
            this.serv2.UseVisualStyleBackColor = false;
            // 
            // serv5
            // 
            this.serv5.AutoSize = true;
            this.serv5.BackColor = System.Drawing.Color.Transparent;
            this.serv5.Checked = true;
            this.serv5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serv5.Enabled = false;
            this.serv5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv5.Location = new System.Drawing.Point(701, 411);
            this.serv5.Name = "serv5";
            this.serv5.Size = new System.Drawing.Size(84, 21);
            this.serv5.TabIndex = 9;
            this.serv5.Text = "Parqueo";
            this.serv5.UseVisualStyleBackColor = false;
            // 
            // serv4
            // 
            this.serv4.AutoSize = true;
            this.serv4.BackColor = System.Drawing.Color.Transparent;
            this.serv4.Enabled = false;
            this.serv4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv4.Location = new System.Drawing.Point(701, 384);
            this.serv4.Name = "serv4";
            this.serv4.Size = new System.Drawing.Size(220, 21);
            this.serv4.TabIndex = 10;
            this.serv4.Text = "Limpieza interior de ventanas ";
            this.serv4.UseVisualStyleBackColor = false;
            // 
            // serv3
            // 
            this.serv3.AutoSize = true;
            this.serv3.BackColor = System.Drawing.Color.Transparent;
            this.serv3.Enabled = false;
            this.serv3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serv3.Location = new System.Drawing.Point(701, 357);
            this.serv3.Name = "serv3";
            this.serv3.Size = new System.Drawing.Size(129, 21);
            this.serv3.TabIndex = 11;
            this.serv3.Text = "Secado a Mano";
            this.serv3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(970, 303);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 129);
            this.textBox2.TabIndex = 20;
            // 
            // serv
            // 
            this.serv.Enabled = false;
            this.serv.Location = new System.Drawing.Point(748, 449);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(103, 49);
            this.serv.TabIndex = 21;
            this.serv.Text = "SERVICIOS";
            this.serv.UseVisualStyleBackColor = true;
            this.serv.Click += new System.EventHandler(this.serv_Click);
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtnom.Enabled = false;
            this.txtnom.Location = new System.Drawing.Point(1282, 47);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 22);
            this.txtnom.TabIndex = 22;
            // 
            // txtplaca
            // 
            this.txtplaca.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtplaca.Enabled = false;
            this.txtplaca.Location = new System.Drawing.Point(1282, 188);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 22);
            this.txtplaca.TabIndex = 23;
            // 
            // txtmarca
            // 
            this.txtmarca.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtmarca.Enabled = false;
            this.txtmarca.Location = new System.Drawing.Point(1282, 139);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 22);
            this.txtmarca.TabIndex = 24;
            // 
            // txtapell
            // 
            this.txtapell.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtapell.Enabled = false;
            this.txtapell.Location = new System.Drawing.Point(1282, 89);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(100, 22);
            this.txtapell.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1197, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1197, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "PLACA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1197, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "MARCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1197, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "APELLIDO";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1269, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 49);
            this.button4.TabIndex = 30;
            this.button4.Text = "GUARDAR REGISTRO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(1204, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 110);
            this.button5.TabIndex = 31;
            this.button5.Text = "RETIRARSE DEL PARQUEO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(181, 564);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 59);
            this.button6.TabIndex = 32;
            this.button6.Text = "FILTRO DE AUTOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::proyecto_estructuras_1.Properties.Resources.alamedas;
            this.pictureBox1.Location = new System.Drawing.Point(663, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 231);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // alamedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::proyecto_estructuras_1.Properties.Resources.allfons_ru_2743;
            this.ClientSize = new System.Drawing.Size(1518, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapell);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.serv);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.serv3);
            this.Controls.Add(this.serv4);
            this.Controls.Add(this.serv5);
            this.Controls.Add(this.serv2);
            this.Controls.Add(this.serv1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "alamedas";
            this.Text = "alamedas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox serv1;
        private System.Windows.Forms.CheckBox serv2;
        private System.Windows.Forms.CheckBox serv5;
        private System.Windows.Forms.CheckBox serv4;
        private System.Windows.Forms.CheckBox serv3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button serv;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}