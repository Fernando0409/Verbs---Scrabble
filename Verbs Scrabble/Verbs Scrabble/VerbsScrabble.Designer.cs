namespace Verbs_Scrabble
{
    partial class VerbsScrabble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerbsScrabble));
            this.menu = new System.Windows.Forms.Panel();
            this.btn_Credits = new System.Windows.Forms.Button();
            this.btn_Tutorial = new System.Windows.Forms.Button();
            this.btn_Contact = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            // Campos estaticos, espero no los elimine la AI
            VerbsScrabble.inicio1 = new Verbs_Scrabble.Inicio();
            VerbsScrabble.categorias1 = new Verbs_Scrabble.Categorias();
            VerbsScrabble.verbsForm1 = new Verbs_Scrabble.VerbsForm();

            this.tutorial1 = new Verbs_Scrabble.Tutorial();
            this.contacto1 = new Verbs_Scrabble.Contacto();
            this.creditos1 = new Verbs_Scrabble.Creditos();
            this.menu.SuspendLayout();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Controls.Add(this.btn_Credits);
            this.menu.Controls.Add(this.btn_Tutorial);
            this.menu.Controls.Add(this.btn_Contact);
            this.menu.Controls.Add(this.btn_Play);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(177, 449);
            this.menu.TabIndex = 1;
            // 
            // btn_Credits
            // 
            this.btn_Credits.FlatAppearance.BorderSize = 0;
            this.btn_Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Credits.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credits.ForeColor = System.Drawing.Color.White;
            this.btn_Credits.Image = ((System.Drawing.Image)(resources.GetObject("btn_Credits.Image")));
            this.btn_Credits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Credits.Location = new System.Drawing.Point(3, 260);
            this.btn_Credits.Name = "btn_Credits";
            this.btn_Credits.Size = new System.Drawing.Size(177, 61);
            this.btn_Credits.TabIndex = 4;
            this.btn_Credits.Text = "  Credits";
            this.btn_Credits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Credits.UseVisualStyleBackColor = true;
            this.btn_Credits.Click += new System.EventHandler(this.btn_Credits_Click);
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.FlatAppearance.BorderSize = 0;
            this.btn_Tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tutorial.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tutorial.ForeColor = System.Drawing.Color.White;
            this.btn_Tutorial.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tutorial.Image")));
            this.btn_Tutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tutorial.Location = new System.Drawing.Point(3, 126);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(177, 61);
            this.btn_Tutorial.TabIndex = 2;
            this.btn_Tutorial.Text = " Tutorial";
            this.btn_Tutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tutorial.UseVisualStyleBackColor = true;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            // 
            // btn_Contact
            // 
            this.btn_Contact.FlatAppearance.BorderSize = 0;
            this.btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contact.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contact.ForeColor = System.Drawing.Color.White;
            this.btn_Contact.Image = ((System.Drawing.Image)(resources.GetObject("btn_Contact.Image")));
            this.btn_Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Contact.Location = new System.Drawing.Point(3, 193);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(177, 61);
            this.btn_Contact.TabIndex = 3;
            this.btn_Contact.Text = "  Contact us";
            this.btn_Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Play.Image")));
            this.btn_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Play.Location = new System.Drawing.Point(3, 59);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(177, 61);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "   Play";
            this.btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.DarkRed;
            this.panelExit.Controls.Add(this.btn_Exit);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExit.Location = new System.Drawing.Point(177, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(667, 53);
            this.panelExit.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(615, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 50);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            //
            // inicio1
            //
            VerbsScrabble.inicio1.Location = new System.Drawing.Point(177, 53);
            VerbsScrabble.inicio1.Name = "inicio1";
            VerbsScrabble.inicio1.Size = new System.Drawing.Size(667, 396);
            VerbsScrabble.inicio1.TabIndex = 7;
            // 
            // tutorial1
            // 
            this.tutorial1.Location = new System.Drawing.Point(177, 53);
            this.tutorial1.Name = "tutorial1";
            this.tutorial1.Size = new System.Drawing.Size(667, 396);
            this.tutorial1.TabIndex = 5;
            // 
            // contacto1
            // 
            this.contacto1.Location = new System.Drawing.Point(177, 53);
            this.contacto1.Name = "contacto1";
            this.contacto1.Size = new System.Drawing.Size(667, 396);
            this.contacto1.TabIndex = 4;
            // 
            // creditos1
            // 
            this.creditos1.Location = new System.Drawing.Point(177, 53);
            this.creditos1.Name = "creditos1";
            this.creditos1.Size = new System.Drawing.Size(667, 396);
            this.creditos1.TabIndex = 3;
            //
            // categorias1
            //
            VerbsScrabble.categorias1.Location = new System.Drawing.Point(177, 53);
            VerbsScrabble.categorias1.Name = "categorias1";
            VerbsScrabble.categorias1.Size = new System.Drawing.Size(667, 396);
            VerbsScrabble.categorias1.TabIndex = 6;
            // 
            // VerbsScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 449);
            this.Controls.Add(VerbsScrabble.inicio1);
            this.Controls.Add(VerbsScrabble.categorias1);
            this.Controls.Add(this.tutorial1);
            this.Controls.Add(this.contacto1);
            this.Controls.Add(this.creditos1);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerbsScrabble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbs Scrabble";
            this.Load += new System.EventHandler(this.VerbsScrabble_Load);
            this.menu.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btn_Credits;
        private System.Windows.Forms.Button btn_Tutorial;
        private System.Windows.Forms.Button btn_Contact;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.PictureBox btn_Exit;
        private Creditos creditos1;
        private Contacto contacto1;
        private Tutorial tutorial1;
        public static Categorias categorias1;
        public static Inicio inicio1;
        public static VerbsForm verbsForm1;
    }
}

