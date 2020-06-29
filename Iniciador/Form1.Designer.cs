namespace Iniciador
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
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_conectar = new System.Windows.Forms.Button();
            this.tb_puerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_destino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_log
            // 
            this.rtb_log.Location = new System.Drawing.Point(42, 370);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.Size = new System.Drawing.Size(401, 130);
            this.rtb_log.TabIndex = 17;
            this.rtb_log.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Logs";
            // 
            // bt_conectar
            // 
            this.bt_conectar.Location = new System.Drawing.Point(698, 82);
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(75, 31);
            this.bt_conectar.TabIndex = 15;
            this.bt_conectar.Text = "Conectar";
            this.bt_conectar.UseVisualStyleBackColor = true;
            this.bt_conectar.Click += new System.EventHandler(this.bt_conectar_Click);
            // 
            // tb_puerto
            // 
            this.tb_puerto.Location = new System.Drawing.Point(458, 42);
            this.tb_puerto.Multiline = true;
            this.tb_puerto.Name = "tb_puerto";
            this.tb_puerto.Size = new System.Drawing.Size(179, 34);
            this.tb_puerto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puerto";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(126, 42);
            this.tb_nombre.Multiline = true;
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(168, 34);
            this.tb_nombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Iniciador";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(458, 119);
            this.tb_numero.Multiline = true;
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(179, 34);
            this.tb_numero.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numero";
            // 
            // tb_destino
            // 
            this.tb_destino.Location = new System.Drawing.Point(126, 119);
            this.tb_destino.Multiline = true;
            this.tb_destino.Name = "tb_destino";
            this.tb_destino.Size = new System.Drawing.Size(168, 34);
            this.tb_destino.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destino:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 527);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_destino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_conectar);
            this.Controls.Add(this.tb_puerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_conectar;
        private System.Windows.Forms.TextBox tb_puerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_destino;
        private System.Windows.Forms.Label label6;
    }
}

