namespace Verbs_Scrabble
{
    partial class Categorias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfinitive = new System.Windows.Forms.Label();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnInfinitive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Past Perfect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Simple Past";
            // 
            // lblInfinitive
            // 
            this.lblInfinitive.AutoSize = true;
            this.lblInfinitive.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfinitive.Location = new System.Drawing.Point(75, 318);
            this.lblInfinitive.Name = "lblInfinitive";
            this.lblInfinitive.Size = new System.Drawing.Size(89, 22);
            this.lblInfinitive.TabIndex = 11;
            this.lblInfinitive.Text = "Inifinitive";
            // 
            // btnPP
            // 
            this.btnPP.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnPP.Location = new System.Drawing.Point(465, 136);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(183, 167);
            this.btnPP.TabIndex = 10;
            this.btnPP.Text = "Insert Picture";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnSP.Location = new System.Drawing.Point(248, 136);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(189, 167);
            this.btnSP.TabIndex = 9;
            this.btnSP.Text = "Insert Picture";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnInfinitive
            // 
            this.btnInfinitive.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfinitive.Location = new System.Drawing.Point(19, 136);
            this.btnInfinitive.Name = "btnInfinitive";
            this.btnInfinitive.Size = new System.Drawing.Size(190, 167);
            this.btnInfinitive.TabIndex = 8;
            this.btnInfinitive.Text = "Insert Picture";
            this.btnInfinitive.UseVisualStyleBackColor = true;
            this.btnInfinitive.Click += new System.EventHandler(this.btnInfinitive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escoge tu Categoria";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfinitive);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnInfinitive);
            this.Controls.Add(this.label1);
            this.Name = "Categorias";
            this.Size = new System.Drawing.Size(667, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfinitive;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnInfinitive;
        private System.Windows.Forms.Label label1;
    }
}
