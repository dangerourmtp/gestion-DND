namespace gestionDnD
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaIds = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.botMinimizar = new System.Windows.Forms.Button();
            this.botCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce el Id de un jugador para añadirlo al menú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(202, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listaIds
            // 
            this.listaIds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaIds.Location = new System.Drawing.Point(14, 328);
            this.listaIds.Name = "listaIds";
            this.listaIds.Size = new System.Drawing.Size(980, 21);
            this.listaIds.TabIndex = 4;
            this.listaIds.Text = "Introducidos:";
            this.listaIds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listaIds.Click += new System.EventHandler(this.listaIds_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(345, 187);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(157, 27);
            this.inputId.TabIndex = 5;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(388, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 77);
            this.button2.TabIndex = 6;
            this.button2.Text = "Listo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botMinimizar
            // 
            this.botMinimizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botMinimizar.ForeColor = System.Drawing.Color.White;
            this.botMinimizar.Location = new System.Drawing.Point(778, 10);
            this.botMinimizar.Name = "botMinimizar";
            this.botMinimizar.Size = new System.Drawing.Size(107, 33);
            this.botMinimizar.TabIndex = 7;
            this.botMinimizar.Text = "Minimizar";
            this.botMinimizar.UseVisualStyleBackColor = false;
            this.botMinimizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // botCerrar
            // 
            this.botCerrar.BackColor = System.Drawing.Color.Maroon;
            this.botCerrar.ForeColor = System.Drawing.Color.White;
            this.botCerrar.Location = new System.Drawing.Point(891, 10);
            this.botCerrar.Name = "botCerrar";
            this.botCerrar.Size = new System.Drawing.Size(103, 33);
            this.botCerrar.TabIndex = 8;
            this.botCerrar.Text = "Cerrar";
            this.botCerrar.UseVisualStyleBackColor = false;
            this.botCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputId);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listaIds);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 514);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1004, 570);
            this.ControlBox = false;
            this.Controls.Add(this.botCerrar);
            this.Controls.Add(this.botMinimizar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión partida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botMinimizar;
        private System.Windows.Forms.Button botCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label listaIds;
    }
}

