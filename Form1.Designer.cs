namespace UPA_Zkouska
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelWeight1 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMolarWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMolarAmount = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelWeight1
            // 
            this.LabelWeight1.AutoSize = true;
            this.LabelWeight1.Location = new System.Drawing.Point(12, 9);
            this.LabelWeight1.Name = "LabelWeight1";
            this.LabelWeight1.Size = new System.Drawing.Size(69, 13);
            this.LabelWeight1.TabIndex = 0;
            this.LabelWeight1.Text = "Hmotnost (m)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(129, 6);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Molární Hmotnost (M)";
            // 
            // textBoxMolarWeight
            // 
            this.textBoxMolarWeight.Location = new System.Drawing.Point(129, 33);
            this.textBoxMolarWeight.Name = "textBoxMolarWeight";
            this.textBoxMolarWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxMolarWeight.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Látkové množství (n)";
            // 
            // TextBoxMolarAmount
            // 
            this.TextBoxMolarAmount.Location = new System.Drawing.Point(129, 63);
            this.TextBoxMolarAmount.Name = "TextBoxMolarAmount";
            this.TextBoxMolarAmount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMolarAmount.TabIndex = 5;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(142, 89);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalculate.TabIndex = 6;
            this.ButtonCalculate.Text = "Úkázat";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TextBoxMolarAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMolarWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.LabelWeight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWeight1;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMolarWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMolarAmount;
        private System.Windows.Forms.Button ButtonCalculate;
    }
}

