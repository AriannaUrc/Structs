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
            this.modifica_button = new System.Windows.Forms.Button();
            this.posizioneMod_textbox = new System.Windows.Forms.TextBox();
            this.posizioneMod_label = new System.Windows.Forms.Label();
            this.nuovoNome_textbox = new System.Windows.Forms.TextBox();
            this.nuovoNome_label = new System.Windows.Forms.Label();
            this.nuovoPrezzo_textbox = new System.Windows.Forms.TextBox();
            this.nuovoPrezzo_label = new System.Windows.Forms.Label();
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
            this.salva_button.Location = new System.Drawing.Point(179, 187);
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
            this.cancella_button.Location = new System.Drawing.Point(37, 253);
            this.cancella_button.Name = "cancella_button";
            this.cancella_button.Size = new System.Drawing.Size(75, 23);
            this.cancella_button.TabIndex = 6;
            this.cancella_button.Text = "Cancella";
            this.cancella_button.UseVisualStyleBackColor = true;
            this.cancella_button.Click += new System.EventHandler(this.cancella_button_Click);
            // 
            // modifica_button
            // 
            this.modifica_button.Location = new System.Drawing.Point(37, 310);
            this.modifica_button.Name = "modifica_button";
            this.modifica_button.Size = new System.Drawing.Size(75, 23);
            this.modifica_button.TabIndex = 7;
            this.modifica_button.Text = "Modifica";
            this.modifica_button.UseVisualStyleBackColor = true;
            this.modifica_button.Click += new System.EventHandler(this.modifica_button_Click);
            // 
            // posizioneMod_textbox
            // 
            this.posizioneMod_textbox.Location = new System.Drawing.Point(135, 313);
            this.posizioneMod_textbox.Name = "posizioneMod_textbox";
            this.posizioneMod_textbox.Size = new System.Drawing.Size(61, 20);
            this.posizioneMod_textbox.TabIndex = 8;
            // 
            // posizioneMod_label
            // 
            this.posizioneMod_label.AutoSize = true;
            this.posizioneMod_label.Location = new System.Drawing.Point(144, 294);
            this.posizioneMod_label.Name = "posizioneMod_label";
            this.posizioneMod_label.Size = new System.Drawing.Size(52, 13);
            this.posizioneMod_label.TabIndex = 9;
            this.posizioneMod_label.Text = "Posizione";
            // 
            // nuovoNome_textbox
            // 
            this.nuovoNome_textbox.Location = new System.Drawing.Point(219, 313);
            this.nuovoNome_textbox.Name = "nuovoNome_textbox";
            this.nuovoNome_textbox.Size = new System.Drawing.Size(100, 20);
            this.nuovoNome_textbox.TabIndex = 10;
            // 
            // nuovoNome_label
            // 
            this.nuovoNome_label.AutoSize = true;
            this.nuovoNome_label.Location = new System.Drawing.Point(234, 294);
            this.nuovoNome_label.Name = "nuovoNome_label";
            this.nuovoNome_label.Size = new System.Drawing.Size(68, 13);
            this.nuovoNome_label.TabIndex = 11;
            this.nuovoNome_label.Text = "Nuovo nome";
            // 
            // nuovoPrezzo_textbox
            // 
            this.nuovoPrezzo_textbox.Location = new System.Drawing.Point(346, 312);
            this.nuovoPrezzo_textbox.Name = "nuovoPrezzo_textbox";
            this.nuovoPrezzo_textbox.Size = new System.Drawing.Size(100, 20);
            this.nuovoPrezzo_textbox.TabIndex = 12;
            // 
            // nuovoPrezzo_label
            // 
            this.nuovoPrezzo_label.AutoSize = true;
            this.nuovoPrezzo_label.Location = new System.Drawing.Point(361, 294);
            this.nuovoPrezzo_label.Name = "nuovoPrezzo_label";
            this.nuovoPrezzo_label.Size = new System.Drawing.Size(73, 13);
            this.nuovoPrezzo_label.TabIndex = 13;
            this.nuovoPrezzo_label.Text = "Nuovo prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nuovoPrezzo_label);
            this.Controls.Add(this.nuovoPrezzo_textbox);
            this.Controls.Add(this.nuovoNome_label);
            this.Controls.Add(this.nuovoNome_textbox);
            this.Controls.Add(this.posizioneMod_label);
            this.Controls.Add(this.posizioneMod_textbox);
            this.Controls.Add(this.modifica_button);
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
        private System.Windows.Forms.Button modifica_button;
        private System.Windows.Forms.TextBox posizioneMod_textbox;
        private System.Windows.Forms.Label posizioneMod_label;
        private System.Windows.Forms.TextBox nuovoNome_textbox;
        private System.Windows.Forms.Label nuovoNome_label;
        private System.Windows.Forms.TextBox nuovoPrezzo_textbox;
        private System.Windows.Forms.Label nuovoPrezzo_label;
    }
}
