namespace ExamenProgramacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TercerMinimizar = new System.Windows.Forms.PictureBox();
            this.TercerEliminar = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cbApartamento = new System.Windows.Forms.ComboBox();
            this.cbEdificio = new System.Windows.Forms.ComboBox();
            this.CbManzana = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TercerMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TercerEliminar)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.TercerMinimizar);
            this.panel1.Controls.Add(this.TercerEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 73);
            this.panel1.TabIndex = 202;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(63, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Habitantes de un condominio.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // TercerMinimizar
            // 
            this.TercerMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("TercerMinimizar.Image")));
            this.TercerMinimizar.Location = new System.Drawing.Point(939, 19);
            this.TercerMinimizar.Name = "TercerMinimizar";
            this.TercerMinimizar.Size = new System.Drawing.Size(25, 25);
            this.TercerMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TercerMinimizar.TabIndex = 1;
            this.TercerMinimizar.TabStop = false;
            this.TercerMinimizar.Click += new System.EventHandler(this.TercerMinimizar_Click);
            // 
            // TercerEliminar
            // 
            this.TercerEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TercerEliminar.Image")));
            this.TercerEliminar.Location = new System.Drawing.Point(970, 19);
            this.TercerEliminar.Name = "TercerEliminar";
            this.TercerEliminar.Size = new System.Drawing.Size(25, 25);
            this.TercerEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TercerEliminar.TabIndex = 0;
            this.TercerEliminar.TabStop = false;
            this.TercerEliminar.Click += new System.EventHandler(this.TercerEliminar_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.cbApartamento);
            this.bunifuGradientPanel2.Controls.Add(this.cbEdificio);
            this.bunifuGradientPanel2.Controls.Add(this.CbManzana);
            this.bunifuGradientPanel2.Controls.Add(this.button4);
            this.bunifuGradientPanel2.Controls.Add(this.btBuscar);
            this.bunifuGradientPanel2.Controls.Add(this.txtBuscar);
            this.bunifuGradientPanel2.Controls.Add(this.label7);
            this.bunifuGradientPanel2.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel2.Controls.Add(this.label11);
            this.bunifuGradientPanel2.Controls.Add(this.button1);
            this.bunifuGradientPanel2.Controls.Add(this.button2);
            this.bunifuGradientPanel2.Controls.Add(this.button3);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.label6);
            this.bunifuGradientPanel2.Controls.Add(this.txtCed);
            this.bunifuGradientPanel2.Controls.Add(this.label9);
            this.bunifuGradientPanel2.Controls.Add(this.label12);
            this.bunifuGradientPanel2.Controls.Add(this.txtNom);
            this.bunifuGradientPanel2.Controls.Add(this.label13);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LavenderBlush;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Gold;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(-20, 57);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1075, 460);
            this.bunifuGradientPanel2.TabIndex = 204;
            // 
            // cbApartamento
            // 
            this.cbApartamento.FormattingEnabled = true;
            this.cbApartamento.Location = new System.Drawing.Point(163, 294);
            this.cbApartamento.Name = "cbApartamento";
            this.cbApartamento.Size = new System.Drawing.Size(183, 21);
            this.cbApartamento.TabIndex = 214;
            // 
            // cbEdificio
            // 
            this.cbEdificio.FormattingEnabled = true;
            this.cbEdificio.Location = new System.Drawing.Point(137, 265);
            this.cbEdificio.Name = "cbEdificio";
            this.cbEdificio.Size = new System.Drawing.Size(209, 21);
            this.cbEdificio.TabIndex = 213;
            // 
            // CbManzana
            // 
            this.CbManzana.FormattingEnabled = true;
            this.CbManzana.Items.AddRange(new object[] {
            "hola"});
            this.CbManzana.Location = new System.Drawing.Point(137, 229);
            this.CbManzana.Name = "CbManzana";
            this.CbManzana.Size = new System.Drawing.Size(209, 21);
            this.CbManzana.TabIndex = 212;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(817, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 37);
            this.button4.TabIndex = 211;
            this.button4.Text = "Mostrar listado de habitantes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Black;
            this.btBuscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Location = new System.Drawing.Point(304, 63);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(84, 26);
            this.btBuscar.TabIndex = 210;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(52, 67);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(230, 20);
            this.txtBuscar.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 17);
            this.label7.TabIndex = 208;
            this.label7.Text = "Buscar el habitante por la cedula";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(427, 49);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 338);
            this.dataGridView1.TabIndex = 205;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 204;
            this.label11.Text = "*-Apartamento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 199;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(303, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 198;
            this.button2.Text = "Eliminar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(175, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 197;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 196;
            this.label1.Text = "Registrar habitante del condominio ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 192;
            this.label6.Text = "*-Manzana";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(137, 169);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(209, 20);
            this.txtCed.TabIndex = 188;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 187;
            this.label9.Text = "*-Cedula";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 184;
            this.label12.Text = "*-Edificio";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(137, 201);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(209, 20);
            this.txtNom.TabIndex = 183;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 182;
            this.label13.Text = "*-Nombre ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 518);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TercerMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TercerEliminar)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox TercerMinimizar;
        private System.Windows.Forms.PictureBox TercerEliminar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.ComboBox cbApartamento;
        private System.Windows.Forms.ComboBox cbEdificio;
        private System.Windows.Forms.ComboBox CbManzana;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label13;
    }
}

