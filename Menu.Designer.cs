namespace WindowsFormsApp1
{
    partial class Menu
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
            this.btcadcliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcadcliente
            // 
            this.btcadcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btcadcliente.Location = new System.Drawing.Point(27, 39);
            this.btcadcliente.Name = "btcadcliente";
            this.btcadcliente.Size = new System.Drawing.Size(425, 72);
            this.btcadcliente.TabIndex = 0;
            this.btcadcliente.Text = "Cadastro de Clientes";
            this.btcadcliente.UseVisualStyleBackColor = true;
            this.btcadcliente.Click += new System.EventHandler(this.btcadcliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(425, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastro de Funcionários";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(425, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cadastro de Produtos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btcadcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Cadastro";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcadcliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}