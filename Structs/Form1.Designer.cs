﻿namespace Structs
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.prezzo_label = new System.Windows.Forms.Label();
            this.salva_button = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListView();
            this.cancella_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(179, 150);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 0;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(317, 150);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 1;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(179, 113);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(35, 13);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "Nome";
            // 
            // prezzo_label
            // 
            this.prezzo_label.AutoSize = true;
            this.prezzo_label.Location = new System.Drawing.Point(314, 113);
            this.prezzo_label.Name = "prezzo_label";
            this.prezzo_label.Size = new System.Drawing.Size(39, 13);
            this.prezzo_label.TabIndex = 3;
            this.prezzo_label.Text = "Prezzo";
            // 
            // salva_button
            // 
            this.salva_button.Location = new System.Drawing.Point(182, 205);
            this.salva_button.Name = "salva_button";
            this.salva_button.Size = new System.Drawing.Size(75, 23);
            this.salva_button.TabIndex = 4;
            this.salva_button.Text = "Salva";
            this.salva_button.UseVisualStyleBackColor = true;
            this.salva_button.Click += new System.EventHandler(this.salva_button_Click);
            // 
            // output
            // 
            this.output.HideSelection = false;
            this.output.Location = new System.Drawing.Point(495, 34);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(282, 374);
            this.output.TabIndex = 5;
            this.output.UseCompatibleStateImageBehavior = false;
            this.output.View = System.Windows.Forms.View.List;
            this.output.SelectedIndexChanged += new System.EventHandler(this.output_SelectedIndexChanged);
            // 
            // cancella_button
            // 
            this.cancella_button.Location = new System.Drawing.Point(182, 254);
            this.cancella_button.Name = "cancella_button";
            this.cancella_button.Size = new System.Drawing.Size(75, 23);
            this.cancella_button.TabIndex = 6;
            this.cancella_button.Text = "Cancella";
            this.cancella_button.UseVisualStyleBackColor = true;
            this.cancella_button.Click += new System.EventHandler(this.cancella_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancella_button);
            this.Controls.Add(this.output);
            this.Controls.Add(this.salva_button);
            this.Controls.Add(this.prezzo_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Nome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label prezzo_label;
        private System.Windows.Forms.Button salva_button;
        private System.Windows.Forms.ListView output;
        private System.Windows.Forms.Button cancella_button;
    }
}

