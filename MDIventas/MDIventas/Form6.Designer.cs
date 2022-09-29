namespace MDIventas
{
    partial class Form6
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
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.dgvcategoria = new System.Windows.Forms.DataGridView();
            this.btneliminarcategoria = new System.Windows.Forms.Button();
            this.btnconsultarcategoria = new System.Windows.Forms.Button();
            this.btnlistarcategoria = new System.Windows.Forms.Button();
            this.btnactualizarcategoria = new System.Windows.Forms.Button();
            this.btnguardarcategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(64, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(418, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Categoria:";
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(160, 205);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(218, 20);
            this.txtidcategoria.TabIndex = 3;
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Location = new System.Drawing.Point(551, 205);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(218, 20);
            this.txtnombrecategoria.TabIndex = 4;
            // 
            // dgvcategoria
            // 
            this.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoria.Location = new System.Drawing.Point(21, 349);
            this.dgvcategoria.Name = "dgvcategoria";
            this.dgvcategoria.Size = new System.Drawing.Size(760, 291);
            this.dgvcategoria.TabIndex = 5;
            // 
            // btneliminarcategoria
            // 
            this.btneliminarcategoria.Location = new System.Drawing.Point(605, 302);
            this.btneliminarcategoria.Name = "btneliminarcategoria";
            this.btneliminarcategoria.Size = new System.Drawing.Size(106, 41);
            this.btneliminarcategoria.TabIndex = 59;
            this.btneliminarcategoria.Text = "Eliminar";
            this.btneliminarcategoria.UseVisualStyleBackColor = true;
            this.btneliminarcategoria.Click += new System.EventHandler(this.btneliminarcategoria_Click);
            // 
            // btnconsultarcategoria
            // 
            this.btnconsultarcategoria.Location = new System.Drawing.Point(475, 302);
            this.btnconsultarcategoria.Name = "btnconsultarcategoria";
            this.btnconsultarcategoria.Size = new System.Drawing.Size(106, 41);
            this.btnconsultarcategoria.TabIndex = 58;
            this.btnconsultarcategoria.Text = "Consultar";
            this.btnconsultarcategoria.UseVisualStyleBackColor = true;
            this.btnconsultarcategoria.Click += new System.EventHandler(this.btnconsultarcategoria_Click);
            // 
            // btnlistarcategoria
            // 
            this.btnlistarcategoria.Location = new System.Drawing.Point(354, 302);
            this.btnlistarcategoria.Name = "btnlistarcategoria";
            this.btnlistarcategoria.Size = new System.Drawing.Size(106, 41);
            this.btnlistarcategoria.TabIndex = 57;
            this.btnlistarcategoria.Text = "Listar";
            this.btnlistarcategoria.UseVisualStyleBackColor = true;
            this.btnlistarcategoria.Click += new System.EventHandler(this.btnlistarcategoria_Click);
            // 
            // btnactualizarcategoria
            // 
            this.btnactualizarcategoria.Location = new System.Drawing.Point(233, 302);
            this.btnactualizarcategoria.Name = "btnactualizarcategoria";
            this.btnactualizarcategoria.Size = new System.Drawing.Size(106, 41);
            this.btnactualizarcategoria.TabIndex = 56;
            this.btnactualizarcategoria.Text = "Actualizar";
            this.btnactualizarcategoria.UseVisualStyleBackColor = true;
            this.btnactualizarcategoria.Click += new System.EventHandler(this.btnactualizarcategoria_Click);
            // 
            // btnguardarcategoria
            // 
            this.btnguardarcategoria.Location = new System.Drawing.Point(108, 302);
            this.btnguardarcategoria.Name = "btnguardarcategoria";
            this.btnguardarcategoria.Size = new System.Drawing.Size(106, 41);
            this.btnguardarcategoria.TabIndex = 55;
            this.btnguardarcategoria.Text = "Guardar";
            this.btnguardarcategoria.UseVisualStyleBackColor = true;
            this.btnguardarcategoria.Click += new System.EventHandler(this.btnguardarcategoria_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.btneliminarcategoria);
            this.Controls.Add(this.btnconsultarcategoria);
            this.Controls.Add(this.btnlistarcategoria);
            this.Controls.Add(this.btnactualizarcategoria);
            this.Controls.Add(this.btnguardarcategoria);
            this.Controls.Add(this.dgvcategoria);
            this.Controls.Add(this.txtnombrecategoria);
            this.Controls.Add(this.txtidcategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Categorias Productos";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.DataGridView dgvcategoria;
        private System.Windows.Forms.Button btneliminarcategoria;
        private System.Windows.Forms.Button btnconsultarcategoria;
        private System.Windows.Forms.Button btnlistarcategoria;
        private System.Windows.Forms.Button btnactualizarcategoria;
        private System.Windows.Forms.Button btnguardarcategoria;
    }
}