namespace Cadastro_Empresa___PDS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cad = new System.Windows.Forms.Button();
            this.bt_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // bt_cad
            // 
            this.bt_cad.Location = new System.Drawing.Point(136, 400);
            this.bt_cad.Name = "bt_cad";
            this.bt_cad.Size = new System.Drawing.Size(172, 80);
            this.bt_cad.TabIndex = 1;
            this.bt_cad.Text = "Cadastro de Empresas";
            this.bt_cad.UseVisualStyleBackColor = true;
            this.bt_cad.Click += new System.EventHandler(this.bt_cad_Click);
            // 
            // bt_list
            // 
            this.bt_list.Location = new System.Drawing.Point(615, 400);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(172, 80);
            this.bt_list.TabIndex = 2;
            this.bt_list.Text = "Lista de Empresas";
            this.bt_list.UseVisualStyleBackColor = true;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 572);
            this.Controls.Add(this.bt_list);
            this.Controls.Add(this.bt_cad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cad;
        private System.Windows.Forms.Button bt_list;
    }
}

