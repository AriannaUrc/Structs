namespace Structs
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
            this.nomeDaMod_textbox = new System.Windows.Forms.TextBox();
            this.nomeDaMod_label = new System.Windows.Forms.Label();
            this.nuovoNome_textbox = new System.Windows.Forms.TextBox();
            this.nuovoNome_label = new System.Windows.Forms.Label();
            this.nuovoPrezzo_textbox = new System.Windows.Forms.TextBox();
            this.nuovoPrezzo_label = new System.Windows.Forms.Label();
            this.nomeDaCancellare_textbox = new System.Windows.Forms.TextBox();
            this.nomeDaCancellare_label = new System.Windows.Forms.Label();
            this.sconto_button = new System.Windows.Forms.Button();
            this.sconto_input = new System.Windows.Forms.TextBox();
            this.sconto_label = new System.Windows.Forms.Label();
            this.sommaPrezzi_button = new System.Windows.Forms.Button();
            this.salva_esterno_buton = new System.Windows.Forms.Button();
            this.carica_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(140, 42);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(98, 20);
            this.nome.TabIndex = 0;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(246, 42);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 1;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(157, 26);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(35, 13);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "Nome";
            // 
            // prezzo_label
            // 
            this.prezzo_label.AutoSize = true;
            this.prezzo_label.Location = new System.Drawing.Point(272, 26);
            this.prezzo_label.Name = "prezzo_label";
            this.prezzo_label.Size = new System.Drawing.Size(39, 13);
            this.prezzo_label.TabIndex = 3;
            this.prezzo_label.Text = "Prezzo";
            // 
            // salva_button
            // 
            this.salva_button.Location = new System.Drawing.Point(30, 42);
            this.salva_button.Name = "salva_button";
            this.salva_button.Size = new System.Drawing.Size(81, 23);
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
            this.cancella_button.Location = new System.Drawing.Point(30, 110);
            this.cancella_button.Name = "cancella_button";
            this.cancella_button.Size = new System.Drawing.Size(81, 23);
            this.cancella_button.TabIndex = 6;
            this.cancella_button.Text = "Cancella";
            this.cancella_button.UseVisualStyleBackColor = true;
            this.cancella_button.Click += new System.EventHandler(this.cancella_button_Click);
            // 
            // modifica_button
            // 
            this.modifica_button.Location = new System.Drawing.Point(30, 167);
            this.modifica_button.Name = "modifica_button";
            this.modifica_button.Size = new System.Drawing.Size(81, 23);
            this.modifica_button.TabIndex = 7;
            this.modifica_button.Text = "Modifica";
            this.modifica_button.UseVisualStyleBackColor = true;
            this.modifica_button.Click += new System.EventHandler(this.modifica_button_Click);
            // 
            // nomeDaMod_textbox
            // 
            this.nomeDaMod_textbox.Location = new System.Drawing.Point(140, 170);
            this.nomeDaMod_textbox.Name = "nomeDaMod_textbox";
            this.nomeDaMod_textbox.Size = new System.Drawing.Size(98, 20);
            this.nomeDaMod_textbox.TabIndex = 8;
            // 
            // nomeDaMod_label
            // 
            this.nomeDaMod_label.AutoSize = true;
            this.nomeDaMod_label.Location = new System.Drawing.Point(137, 151);
            this.nomeDaMod_label.Name = "nomeDaMod_label";
            this.nomeDaMod_label.Size = new System.Drawing.Size(101, 13);
            this.nomeDaMod_label.TabIndex = 9;
            this.nomeDaMod_label.Text = "Nome da modificare";
            // 
            // nuovoNome_textbox
            // 
            this.nuovoNome_textbox.Location = new System.Drawing.Point(246, 170);
            this.nuovoNome_textbox.Name = "nuovoNome_textbox";
            this.nuovoNome_textbox.Size = new System.Drawing.Size(100, 20);
            this.nuovoNome_textbox.TabIndex = 10;
            // 
            // nuovoNome_label
            // 
            this.nuovoNome_label.AutoSize = true;
            this.nuovoNome_label.Location = new System.Drawing.Point(260, 151);
            this.nuovoNome_label.Name = "nuovoNome_label";
            this.nuovoNome_label.Size = new System.Drawing.Size(68, 13);
            this.nuovoNome_label.TabIndex = 11;
            this.nuovoNome_label.Text = "Nuovo nome";
            // 
            // nuovoPrezzo_textbox
            // 
            this.nuovoPrezzo_textbox.Location = new System.Drawing.Point(357, 169);
            this.nuovoPrezzo_textbox.Name = "nuovoPrezzo_textbox";
            this.nuovoPrezzo_textbox.Size = new System.Drawing.Size(70, 20);
            this.nuovoPrezzo_textbox.TabIndex = 12;
            // 
            // nuovoPrezzo_label
            // 
            this.nuovoPrezzo_label.AutoSize = true;
            this.nuovoPrezzo_label.Location = new System.Drawing.Point(354, 151);
            this.nuovoPrezzo_label.Name = "nuovoPrezzo_label";
            this.nuovoPrezzo_label.Size = new System.Drawing.Size(73, 13);
            this.nuovoPrezzo_label.TabIndex = 13;
            this.nuovoPrezzo_label.Text = "Nuovo prezzo";
            // 
            // nomeDaCancellare_textbox
            // 
            this.nomeDaCancellare_textbox.Location = new System.Drawing.Point(140, 112);
            this.nomeDaCancellare_textbox.Name = "nomeDaCancellare_textbox";
            this.nomeDaCancellare_textbox.Size = new System.Drawing.Size(100, 20);
            this.nomeDaCancellare_textbox.TabIndex = 14;
            // 
            // nomeDaCancellare_label
            // 
            this.nomeDaCancellare_label.AutoSize = true;
            this.nomeDaCancellare_label.Location = new System.Drawing.Point(138, 87);
            this.nomeDaCancellare_label.Name = "nomeDaCancellare_label";
            this.nomeDaCancellare_label.Size = new System.Drawing.Size(102, 13);
            this.nomeDaCancellare_label.TabIndex = 15;
            this.nomeDaCancellare_label.Text = "Nome da cancellare";
            // 
            // sconto_button
            // 
            this.sconto_button.Location = new System.Drawing.Point(30, 230);
            this.sconto_button.Name = "sconto_button";
            this.sconto_button.Size = new System.Drawing.Size(81, 23);
            this.sconto_button.TabIndex = 16;
            this.sconto_button.Text = "Sconta";
            this.sconto_button.UseVisualStyleBackColor = true;
            this.sconto_button.Click += new System.EventHandler(this.sconto_button_Click);
            // 
            // sconto_input
            // 
            this.sconto_input.Location = new System.Drawing.Point(141, 230);
            this.sconto_input.Name = "sconto_input";
            this.sconto_input.Size = new System.Drawing.Size(110, 20);
            this.sconto_input.TabIndex = 17;
            // 
            // sconto_label
            // 
            this.sconto_label.AutoSize = true;
            this.sconto_label.Location = new System.Drawing.Point(140, 214);
            this.sconto_label.Name = "sconto_label";
            this.sconto_label.Size = new System.Drawing.Size(111, 13);
            this.sconto_label.TabIndex = 18;
            this.sconto_label.Text = "Sconto in percentuale";
            // 
            // sommaPrezzi_button
            // 
            this.sommaPrezzi_button.Location = new System.Drawing.Point(30, 289);
            this.sommaPrezzi_button.Name = "sommaPrezzi_button";
            this.sommaPrezzi_button.Size = new System.Drawing.Size(81, 23);
            this.sommaPrezzi_button.TabIndex = 19;
            this.sommaPrezzi_button.Text = "Somma prezzi";
            this.sommaPrezzi_button.UseVisualStyleBackColor = true;
            this.sommaPrezzi_button.Click += new System.EventHandler(this.sommaPrezzi_button_Click);
            // 
            // salva_esterno_buton
            // 
            this.salva_esterno_buton.Location = new System.Drawing.Point(30, 385);
            this.salva_esterno_buton.Name = "salva_esterno_buton";
            this.salva_esterno_buton.Size = new System.Drawing.Size(81, 23);
            this.salva_esterno_buton.TabIndex = 20;
            this.salva_esterno_buton.Text = "Salva su file";
            this.salva_esterno_buton.UseVisualStyleBackColor = true;
            this.salva_esterno_buton.Click += new System.EventHandler(this.salva_buton_Click);
            // 
            // carica_button
            // 
            this.carica_button.Location = new System.Drawing.Point(143, 385);
            this.carica_button.Name = "carica_button";
            this.carica_button.Size = new System.Drawing.Size(81, 23);
            this.carica_button.TabIndex = 21;
            this.carica_button.Text = "Carica da file";
            this.carica_button.UseVisualStyleBackColor = true;
            this.carica_button.Click += new System.EventHandler(this.carica_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carica_button);
            this.Controls.Add(this.salva_esterno_buton);
            this.Controls.Add(this.sommaPrezzi_button);
            this.Controls.Add(this.sconto_label);
            this.Controls.Add(this.sconto_input);
            this.Controls.Add(this.sconto_button);
            this.Controls.Add(this.nomeDaCancellare_label);
            this.Controls.Add(this.nomeDaCancellare_textbox);
            this.Controls.Add(this.nuovoPrezzo_label);
            this.Controls.Add(this.nuovoPrezzo_textbox);
            this.Controls.Add(this.nuovoNome_label);
            this.Controls.Add(this.nuovoNome_textbox);
            this.Controls.Add(this.nomeDaMod_label);
            this.Controls.Add(this.nomeDaMod_textbox);
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
        private System.Windows.Forms.TextBox nomeDaMod_textbox;
        private System.Windows.Forms.Label nomeDaMod_label;
        private System.Windows.Forms.TextBox nuovoNome_textbox;
        private System.Windows.Forms.Label nuovoNome_label;
        private System.Windows.Forms.TextBox nuovoPrezzo_textbox;
        private System.Windows.Forms.Label nuovoPrezzo_label;
        private System.Windows.Forms.TextBox nomeDaCancellare_textbox;
        private System.Windows.Forms.Label nomeDaCancellare_label;
        private System.Windows.Forms.Button sconto_button;
        private System.Windows.Forms.TextBox sconto_input;
        private System.Windows.Forms.Label sconto_label;
        private System.Windows.Forms.Button sommaPrezzi_button;
        private System.Windows.Forms.Button salva_esterno_buton;
        private System.Windows.Forms.Button carica_button;
    }
}

