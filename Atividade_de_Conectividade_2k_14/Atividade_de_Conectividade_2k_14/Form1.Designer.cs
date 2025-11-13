namespace Atividade_de_Conectividade_2k_14
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_AnoN = new System.Windows.Forms.TextBox();
            this.btn_Localizar = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Registros - Autores (Banco biblioteca) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID (Chave primária):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de Nascimento:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(257, 88);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(143, 20);
            this.txt_Id.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(257, 136);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(382, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_AnoN
            // 
            this.txt_AnoN.Location = new System.Drawing.Point(257, 182);
            this.txt_AnoN.Name = "txt_AnoN";
            this.txt_AnoN.Size = new System.Drawing.Size(143, 20);
            this.txt_AnoN.TabIndex = 6;
            // 
            // btn_Localizar
            // 
            this.btn_Localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Localizar.Location = new System.Drawing.Point(432, 88);
            this.btn_Localizar.Name = "btn_Localizar";
            this.btn_Localizar.Size = new System.Drawing.Size(207, 35);
            this.btn_Localizar.TabIndex = 7;
            this.btn_Localizar.Text = "Localizar";
            this.btn_Localizar.UseVisualStyleBackColor = true;
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.Location = new System.Drawing.Point(432, 173);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(207, 39);
            this.btn_Finalizar.TabIndex = 8;
            this.btn_Finalizar.Text = "Finalizar tarefa";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 263);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Localizar);
            this.Controls.Add(this.txt_AnoN);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Busca de Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_AnoN;
        private System.Windows.Forms.Button btn_Localizar;
        private System.Windows.Forms.Button btn_Finalizar;
    }
}

