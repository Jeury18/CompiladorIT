
namespace CompiladorIT
{
    partial class compilador
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.compilar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoSalida = new System.Windows.Forms.RichTextBox();
            this.CodigoEntrada = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "PRUEBA.TXT DONDE TIENE EL CODIGO A COMPILAR DE PRUBA.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "PARA COMPILAR EL PROGRAMA HAY UN ARCHIVO LLAMADO ";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(293, 222);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(193, 45);
            this.salir.TabIndex = 15;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Gray;
            this.limpiar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(293, 140);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(193, 47);
            this.limpiar.TabIndex = 14;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // compilar
            // 
            this.compilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.compilar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilar.Location = new System.Drawing.Point(293, 61);
            this.compilar.Name = "compilar";
            this.compilar.Size = new System.Drawing.Size(193, 49);
            this.compilar.TabIndex = 13;
            this.compilar.Text = "COMPILAR";
            this.compilar.UseVisualStyleBackColor = false;
            this.compilar.Click += new System.EventHandler(this.compilar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "GENERACION DE CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "CADENA DE ENTRADA";
            // 
            // CodigoSalida
            // 
            this.CodigoSalida.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSalida.Location = new System.Drawing.Point(21, 257);
            this.CodigoSalida.Name = "CodigoSalida";
            this.CodigoSalida.Size = new System.Drawing.Size(228, 170);
            this.CodigoSalida.TabIndex = 10;
            this.CodigoSalida.Text = "";
            // 
            // CodigoEntrada
            // 
            this.CodigoEntrada.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoEntrada.Location = new System.Drawing.Point(21, 47);
            this.CodigoEntrada.Name = "CodigoEntrada";
            this.CodigoEntrada.Size = new System.Drawing.Size(228, 170);
            this.CodigoEntrada.TabIndex = 9;
            this.CodigoEntrada.Text = "";
            // 
            // compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.compilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoSalida);
            this.Controls.Add(this.CodigoEntrada);
            this.Name = "compilador";
            this.Text = "COMPILADOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button compilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CodigoSalida;
        private System.Windows.Forms.RichTextBox CodigoEntrada;
    }
}

