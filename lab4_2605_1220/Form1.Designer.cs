namespace lab4_2605_1220
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.send_button = new System.Windows.Forms.Button();
            this.send_textbox = new System.Windows.Forms.RichTextBox();
            this.receive_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(608, 170);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(93, 52);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // send_textbox
            // 
            this.send_textbox.Location = new System.Drawing.Point(173, 126);
            this.send_textbox.Name = "send_textbox";
            this.send_textbox.Size = new System.Drawing.Size(400, 96);
            this.send_textbox.TabIndex = 2;
            this.send_textbox.Text = "";
            // 
            // receive_textbox
            // 
            this.receive_textbox.Location = new System.Drawing.Point(173, 276);
            this.receive_textbox.Name = "receive_textbox";
            this.receive_textbox.Size = new System.Drawing.Size(400, 96);
            this.receive_textbox.TabIndex = 3;
            this.receive_textbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 493);
            this.Controls.Add(this.receive_textbox);
            this.Controls.Add(this.send_textbox);
            this.Controls.Add(this.send_button);
            this.Name = "Form1";
            this.Text = "```";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.RichTextBox send_textbox;
        private System.Windows.Forms.RichTextBox receive_textbox;
    }
}

