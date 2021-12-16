
namespace Kalkulator_ulamkowy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.substractButton = new System.Windows.Forms.RadioButton();
            this.timesButton = new System.Windows.Forms.RadioButton();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.liczba1cala = new System.Windows.Forms.TextBox();
            this.liczebnik1 = new System.Windows.Forms.TextBox();
            this.mianownik1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.liczebnik2 = new System.Windows.Forms.TextBox();
            this.liczba2cala = new System.Windows.Forms.TextBox();
            this.mianownik2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equalButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wynikLicznikTxt = new System.Windows.Forms.TextBox();
            this.wynikCala = new System.Windows.Forms.TextBox();
            this.wynikMianownikTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.divideButton);
            this.groupBox1.Controls.Add(this.timesButton);
            this.groupBox1.Controls.Add(this.substractButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(245, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(7, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 17);
            this.addButton.TabIndex = 0;
            this.addButton.TabStop = true;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // substractButton
            // 
            this.substractButton.AutoSize = true;
            this.substractButton.Location = new System.Drawing.Point(7, 44);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(28, 17);
            this.substractButton.TabIndex = 1;
            this.substractButton.TabStop = true;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = true;
            // 
            // timesButton
            // 
            this.timesButton.AutoSize = true;
            this.timesButton.Location = new System.Drawing.Point(7, 68);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(29, 17);
            this.timesButton.TabIndex = 2;
            this.timesButton.TabStop = true;
            this.timesButton.Text = "*";
            this.timesButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.AutoSize = true;
            this.divideButton.Location = new System.Drawing.Point(7, 92);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(30, 17);
            this.divideButton.TabIndex = 3;
            this.divideButton.TabStop = true;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // liczba1cala
            // 
            this.liczba1cala.Location = new System.Drawing.Point(30, 41);
            this.liczba1cala.Name = "liczba1cala";
            this.liczba1cala.Size = new System.Drawing.Size(26, 20);
            this.liczba1cala.TabIndex = 1;
            // 
            // liczebnik1
            // 
            this.liczebnik1.Location = new System.Drawing.Point(72, 19);
            this.liczebnik1.Name = "liczebnik1";
            this.liczebnik1.Size = new System.Drawing.Size(26, 20);
            this.liczebnik1.TabIndex = 2;
            // 
            // mianownik1
            // 
            this.mianownik1.Location = new System.Drawing.Point(72, 63);
            this.mianownik1.Name = "mianownik1";
            this.mianownik1.Size = new System.Drawing.Size(26, 20);
            this.mianownik1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.liczebnik1);
            this.groupBox2.Controls.Add(this.liczba1cala);
            this.groupBox2.Controls.Add(this.mianownik1);
            this.groupBox2.Location = new System.Drawing.Point(102, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liczba 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.liczebnik2);
            this.groupBox3.Controls.Add(this.liczba2cala);
            this.groupBox3.Controls.Add(this.mianownik2);
            this.groupBox3.Location = new System.Drawing.Point(349, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liczba 2";
            // 
            // liczebnik2
            // 
            this.liczebnik2.Location = new System.Drawing.Point(72, 19);
            this.liczebnik2.Name = "liczebnik2";
            this.liczebnik2.Size = new System.Drawing.Size(26, 20);
            this.liczebnik2.TabIndex = 2;
            // 
            // liczba2cala
            // 
            this.liczba2cala.Location = new System.Drawing.Point(30, 41);
            this.liczba2cala.Name = "liczba2cala";
            this.liczba2cala.Size = new System.Drawing.Size(26, 20);
            this.liczba2cala.TabIndex = 1;
            // 
            // mianownik2
            // 
            this.mianownik2.Location = new System.Drawing.Point(72, 63);
            this.mianownik2.Name = "mianownik2";
            this.mianownik2.Size = new System.Drawing.Size(26, 20);
            this.mianownik2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(526, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalButton.Location = new System.Drawing.Point(494, 289);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(95, 37);
            this.equalButton.TabIndex = 8;
            this.equalButton.Text = "Policz";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wynikLicznikTxt);
            this.groupBox4.Controls.Add(this.wynikCala);
            this.groupBox4.Controls.Add(this.wynikMianownikTxt);
            this.groupBox4.Location = new System.Drawing.Point(578, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wynik";
            // 
            // wynikLicznikTxt
            // 
            this.wynikLicznikTxt.Location = new System.Drawing.Point(72, 19);
            this.wynikLicznikTxt.Name = "wynikLicznikTxt";
            this.wynikLicznikTxt.Size = new System.Drawing.Size(26, 20);
            this.wynikLicznikTxt.TabIndex = 2;
            // 
            // wynikCala
            // 
            this.wynikCala.Location = new System.Drawing.Point(30, 41);
            this.wynikCala.Name = "wynikCala";
            this.wynikCala.Size = new System.Drawing.Size(26, 20);
            this.wynikCala.TabIndex = 1;
            // 
            // wynikMianownikTxt
            // 
            this.wynikMianownikTxt.Location = new System.Drawing.Point(72, 63);
            this.wynikMianownikTxt.Name = "wynikMianownikTxt";
            this.wynikMianownikTxt.Size = new System.Drawing.Size(26, 20);
            this.wynikMianownikTxt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.RadioButton timesButton;
        private System.Windows.Forms.RadioButton substractButton;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.TextBox liczba1cala;
        private System.Windows.Forms.TextBox liczebnik1;
        private System.Windows.Forms.TextBox mianownik1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox liczebnik2;
        private System.Windows.Forms.TextBox liczba2cala;
        private System.Windows.Forms.TextBox mianownik2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox wynikLicznikTxt;
        private System.Windows.Forms.TextBox wynikCala;
        private System.Windows.Forms.TextBox wynikMianownikTxt;
    }
}

