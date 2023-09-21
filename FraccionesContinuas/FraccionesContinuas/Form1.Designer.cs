namespace FraccionesContinuas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dato1 = new System.Windows.Forms.TextBox();
            this.Dato2 = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "1er Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "2do Número";
            // 
            // Dato1
            // 
            this.Dato1.Location = new System.Drawing.Point(241, 80);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(112, 24);
            this.Dato1.TabIndex = 3;
            // 
            // Dato2
            // 
            this.Dato2.Location = new System.Drawing.Point(588, 80);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(112, 24);
            this.Dato2.TabIndex = 4;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(101, 414);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(118, 32);
            this.BtnIniciar.TabIndex = 5;
            this.BtnIniciar.Text = "Calcular";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGW1
            // 
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.c2,
            this.c3});
            this.dGW1.Location = new System.Drawing.Point(136, 142);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(615, 236);
            this.dGW1.TabIndex = 7;
            // 
            // C1
            // 
            this.C1.HeaderText = "Paso";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 125;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c2.HeaderText = "Operación";
            this.c2.MaxInputLength = 42769;
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Width = 112;
            // 
            // c3
            // 
            this.c3.HeaderText = "Ecuación";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fracciones Continuas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGW1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Dato1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 7.8F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fracciones Continuas";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dato1;
        private System.Windows.Forms.TextBox Dato2;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGW1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.Label label3;
    }
}

