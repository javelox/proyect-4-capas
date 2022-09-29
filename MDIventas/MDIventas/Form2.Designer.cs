namespace MDIventas
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtapellidocliente = new System.Windows.Forms.TextBox();
            this.txtdireccioncliente = new System.Windows.Forms.TextBox();
            this.txttelefonocliente = new System.Windows.Forms.TextBox();
            this.txtcorreocliente = new System.Windows.Forms.TextBox();
            this.btnguardarcliente = new System.Windows.Forms.Button();
            this.btnactualizarcliente = new System.Windows.Forms.Button();
            this.btnlistarcliente = new System.Windows.Forms.Button();
            this.btnconsultarcliente = new System.Windows.Forms.Button();
            this.btneliminarcliente = new System.Windows.Forms.Button();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(63, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(394, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(73, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(388, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(80, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(385, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion:";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(141, 138);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(208, 20);
            this.txtidcliente.TabIndex = 7;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(462, 138);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(208, 20);
            this.txtnombrecliente.TabIndex = 8;
            // 
            // txtapellidocliente
            // 
            this.txtapellidocliente.Location = new System.Drawing.Point(141, 221);
            this.txtapellidocliente.Name = "txtapellidocliente";
            this.txtapellidocliente.Size = new System.Drawing.Size(208, 20);
            this.txtapellidocliente.TabIndex = 9;
            // 
            // txtdireccioncliente
            // 
            this.txtdireccioncliente.Location = new System.Drawing.Point(462, 292);
            this.txtdireccioncliente.Name = "txtdireccioncliente";
            this.txtdireccioncliente.Size = new System.Drawing.Size(208, 20);
            this.txtdireccioncliente.TabIndex = 10;
            // 
            // txttelefonocliente
            // 
            this.txttelefonocliente.Location = new System.Drawing.Point(462, 221);
            this.txttelefonocliente.Name = "txttelefonocliente";
            this.txttelefonocliente.Size = new System.Drawing.Size(208, 20);
            this.txttelefonocliente.TabIndex = 10;
            // 
            // txtcorreocliente
            // 
            this.txtcorreocliente.Location = new System.Drawing.Point(141, 292);
            this.txtcorreocliente.Name = "txtcorreocliente";
            this.txtcorreocliente.Size = new System.Drawing.Size(208, 20);
            this.txtcorreocliente.TabIndex = 11;
            // 
            // btnguardarcliente
            // 
            this.btnguardarcliente.Location = new System.Drawing.Point(80, 372);
            this.btnguardarcliente.Name = "btnguardarcliente";
            this.btnguardarcliente.Size = new System.Drawing.Size(106, 41);
            this.btnguardarcliente.TabIndex = 12;
            this.btnguardarcliente.Text = "Guardar";
            this.btnguardarcliente.UseVisualStyleBackColor = true;
            this.btnguardarcliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnactualizarcliente
            // 
            this.btnactualizarcliente.Location = new System.Drawing.Point(205, 372);
            this.btnactualizarcliente.Name = "btnactualizarcliente";
            this.btnactualizarcliente.Size = new System.Drawing.Size(106, 41);
            this.btnactualizarcliente.TabIndex = 13;
            this.btnactualizarcliente.Text = "Actualizar";
            this.btnactualizarcliente.UseVisualStyleBackColor = true;
            this.btnactualizarcliente.Click += new System.EventHandler(this.btnactualizarcliente_Click);
            // 
            // btnlistarcliente
            // 
            this.btnlistarcliente.Location = new System.Drawing.Point(326, 372);
            this.btnlistarcliente.Name = "btnlistarcliente";
            this.btnlistarcliente.Size = new System.Drawing.Size(106, 41);
            this.btnlistarcliente.TabIndex = 14;
            this.btnlistarcliente.Text = "Listar";
            this.btnlistarcliente.UseVisualStyleBackColor = true;
            this.btnlistarcliente.Click += new System.EventHandler(this.btnlistarcliente_Click);
            // 
            // btnconsultarcliente
            // 
            this.btnconsultarcliente.Location = new System.Drawing.Point(447, 372);
            this.btnconsultarcliente.Name = "btnconsultarcliente";
            this.btnconsultarcliente.Size = new System.Drawing.Size(106, 41);
            this.btnconsultarcliente.TabIndex = 15;
            this.btnconsultarcliente.Text = "Consultar";
            this.btnconsultarcliente.UseVisualStyleBackColor = true;
            this.btnconsultarcliente.Click += new System.EventHandler(this.btnconsultarcliente_Click);
            // 
            // btneliminarcliente
            // 
            this.btneliminarcliente.Location = new System.Drawing.Point(577, 372);
            this.btneliminarcliente.Name = "btneliminarcliente";
            this.btneliminarcliente.Size = new System.Drawing.Size(106, 41);
            this.btneliminarcliente.TabIndex = 16;
            this.btneliminarcliente.Text = "Eliminar";
            this.btneliminarcliente.UseVisualStyleBackColor = true;
            this.btneliminarcliente.Click += new System.EventHandler(this.btneliminarcliente_Click);
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(41, 445);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(725, 332);
            this.dgvcliente.TabIndex = 17;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 789);
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.btneliminarcliente);
            this.Controls.Add(this.btnconsultarcliente);
            this.Controls.Add(this.btnlistarcliente);
            this.Controls.Add(this.btnactualizarcliente);
            this.Controls.Add(this.btnguardarcliente);
            this.Controls.Add(this.txtcorreocliente);
            this.Controls.Add(this.txttelefonocliente);
            this.Controls.Add(this.txtdireccioncliente);
            this.Controls.Add(this.txtapellidocliente);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtapellidocliente;
        private System.Windows.Forms.TextBox txtdireccioncliente;
        private System.Windows.Forms.TextBox txttelefonocliente;
        private System.Windows.Forms.TextBox txtcorreocliente;
        private System.Windows.Forms.Button btnguardarcliente;
        private System.Windows.Forms.Button btnactualizarcliente;
        private System.Windows.Forms.Button btnlistarcliente;
        private System.Windows.Forms.Button btnconsultarcliente;
        private System.Windows.Forms.Button btneliminarcliente;
        private System.Windows.Forms.DataGridView dgvcliente;
    }
}