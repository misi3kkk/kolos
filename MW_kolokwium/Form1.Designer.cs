namespace MW_kolokwium
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator BMI, PPM i CPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Płeć:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(2, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(2, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wzrost:";
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(59, 73);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(120, 20);
            this.wiek.TabIndex = 6;
            this.wiek.ValueChanged += new System.EventHandler(this.wiek_ValueChanged);
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(59, 99);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(120, 20);
            this.waga.TabIndex = 7;
            this.waga.ValueChanged += new System.EventHandler(this.waga_ValueChanged);
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(59, 125);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(120, 20);
            this.wzrost.TabIndex = 8;
            this.wzrost.ValueChanged += new System.EventHandler(this.wzrost_ValueChanged);
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(59, 46);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(34, 17);
            this.man.TabIndex = 9;
            this.man.TabStop = true;
            this.man.Text = "M";
            this.man.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(99, 46);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(32, 17);
            this.woman.TabIndex = 10;
            this.woman.TabStop = true;
            this.woman.Text = "K";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(185, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "(18-99)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(185, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(185, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "cm";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Brak aktywności",
            "Bardzo lekka aktywność (1 dzień w tygodniu)",
            "Lekka aktywność (2-3 dni w tygodniu)",
            "Średnia aktywność (4-5 dni w tygodniu)",
            "Duża aktywność (codziennie)",
            "Bardzo duża aktywność"});
            this.lista.Location = new System.Drawing.Point(33, 160);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(227, 21);
            this.lista.TabIndex = 14;
            this.lista.Text = "Poziom aktywności fizycznej";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(33, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.NumericUpDown waga;
        private System.Windows.Forms.NumericUpDown wzrost;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.Button button1;
    }
}

