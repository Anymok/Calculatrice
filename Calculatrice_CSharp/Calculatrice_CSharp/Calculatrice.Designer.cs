
namespace Calculatrice_CSharp
{
    partial class FM_Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_reset = new System.Windows.Forms.Button();
            this.BTN_result = new System.Windows.Forms.Button();
            this.BTN_addition = new System.Windows.Forms.Button();
            this.BTN_9 = new System.Windows.Forms.Button();
            this.BTN_8 = new System.Windows.Forms.Button();
            this.BTN_7 = new System.Windows.Forms.Button();
            this.BTN_6 = new System.Windows.Forms.Button();
            this.BTN_5 = new System.Windows.Forms.Button();
            this.BTN_4 = new System.Windows.Forms.Button();
            this.BTN_3 = new System.Windows.Forms.Button();
            this.BTN_1 = new System.Windows.Forms.Button();
            this.BTN_2 = new System.Windows.Forms.Button();
            this.BTN_0 = new System.Windows.Forms.Button();
            this.TXT_champs = new System.Windows.Forms.TextBox();
            this.BTN_soustraction = new System.Windows.Forms.Button();
            this.BTN_multiplication = new System.Windows.Forms.Button();
            this.BTN_division = new System.Windows.Forms.Button();
            this.BTN_virgule1 = new System.Windows.Forms.Button();
            this.BTN_negatif = new System.Windows.Forms.Button();
            this.btnPuissance = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_reset.Location = new System.Drawing.Point(210, 62);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(65, 65);
            this.BTN_reset.TabIndex = 26;
            this.BTN_reset.Text = "C";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // BTN_result
            // 
            this.BTN_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_result.Location = new System.Drawing.Point(281, 346);
            this.BTN_result.Name = "BTN_result";
            this.BTN_result.Size = new System.Drawing.Size(65, 65);
            this.BTN_result.TabIndex = 25;
            this.BTN_result.Text = "=";
            this.BTN_result.UseVisualStyleBackColor = true;
            this.BTN_result.Click += new System.EventHandler(this.BTN_result_Click);
            // 
            // BTN_addition
            // 
            this.BTN_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_addition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_addition.Location = new System.Drawing.Point(281, 275);
            this.BTN_addition.Name = "BTN_addition";
            this.BTN_addition.Size = new System.Drawing.Size(65, 65);
            this.BTN_addition.TabIndex = 24;
            this.BTN_addition.Text = "+";
            this.BTN_addition.UseVisualStyleBackColor = true;
            this.BTN_addition.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // BTN_9
            // 
            this.BTN_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_9.Location = new System.Drawing.Point(210, 133);
            this.BTN_9.Name = "BTN_9";
            this.BTN_9.Size = new System.Drawing.Size(65, 65);
            this.BTN_9.TabIndex = 23;
            this.BTN_9.Text = "9";
            this.BTN_9.UseVisualStyleBackColor = true;
            this.BTN_9.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_8
            // 
            this.BTN_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_8.Location = new System.Drawing.Point(139, 133);
            this.BTN_8.Name = "BTN_8";
            this.BTN_8.Size = new System.Drawing.Size(65, 65);
            this.BTN_8.TabIndex = 22;
            this.BTN_8.Text = "8";
            this.BTN_8.UseVisualStyleBackColor = true;
            this.BTN_8.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_7
            // 
            this.BTN_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_7.Location = new System.Drawing.Point(68, 133);
            this.BTN_7.Name = "BTN_7";
            this.BTN_7.Size = new System.Drawing.Size(65, 65);
            this.BTN_7.TabIndex = 21;
            this.BTN_7.Text = "7";
            this.BTN_7.UseVisualStyleBackColor = true;
            this.BTN_7.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_6
            // 
            this.BTN_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_6.Location = new System.Drawing.Point(210, 204);
            this.BTN_6.Name = "BTN_6";
            this.BTN_6.Size = new System.Drawing.Size(65, 65);
            this.BTN_6.TabIndex = 20;
            this.BTN_6.Text = "6";
            this.BTN_6.UseVisualStyleBackColor = true;
            this.BTN_6.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_5
            // 
            this.BTN_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_5.Location = new System.Drawing.Point(139, 204);
            this.BTN_5.Name = "BTN_5";
            this.BTN_5.Size = new System.Drawing.Size(65, 65);
            this.BTN_5.TabIndex = 19;
            this.BTN_5.Text = "5";
            this.BTN_5.UseVisualStyleBackColor = true;
            this.BTN_5.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_4
            // 
            this.BTN_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_4.Location = new System.Drawing.Point(68, 204);
            this.BTN_4.Name = "BTN_4";
            this.BTN_4.Size = new System.Drawing.Size(65, 65);
            this.BTN_4.TabIndex = 18;
            this.BTN_4.Text = "4";
            this.BTN_4.UseVisualStyleBackColor = true;
            this.BTN_4.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_3
            // 
            this.BTN_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_3.Location = new System.Drawing.Point(210, 273);
            this.BTN_3.Name = "BTN_3";
            this.BTN_3.Size = new System.Drawing.Size(65, 65);
            this.BTN_3.TabIndex = 17;
            this.BTN_3.Text = "3";
            this.BTN_3.UseVisualStyleBackColor = true;
            this.BTN_3.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_1
            // 
            this.BTN_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_1.Location = new System.Drawing.Point(68, 275);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(65, 65);
            this.BTN_1.TabIndex = 16;
            this.BTN_1.Text = "1";
            this.BTN_1.UseVisualStyleBackColor = true;
            this.BTN_1.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_2
            // 
            this.BTN_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_2.Location = new System.Drawing.Point(139, 275);
            this.BTN_2.Name = "BTN_2";
            this.BTN_2.Size = new System.Drawing.Size(65, 65);
            this.BTN_2.TabIndex = 15;
            this.BTN_2.Text = "2";
            this.BTN_2.UseVisualStyleBackColor = true;
            this.BTN_2.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_0
            // 
            this.BTN_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_0.Location = new System.Drawing.Point(139, 346);
            this.BTN_0.Name = "BTN_0";
            this.BTN_0.Size = new System.Drawing.Size(65, 65);
            this.BTN_0.TabIndex = 14;
            this.BTN_0.Text = "0";
            this.BTN_0.UseVisualStyleBackColor = true;
            this.BTN_0.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // TXT_champs
            // 
            this.TXT_champs.Location = new System.Drawing.Point(12, 12);
            this.TXT_champs.Multiline = true;
            this.TXT_champs.Name = "TXT_champs";
            this.TXT_champs.Size = new System.Drawing.Size(390, 25);
            this.TXT_champs.TabIndex = 27;
            // 
            // BTN_soustraction
            // 
            this.BTN_soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_soustraction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_soustraction.Location = new System.Drawing.Point(281, 204);
            this.BTN_soustraction.Name = "BTN_soustraction";
            this.BTN_soustraction.Size = new System.Drawing.Size(65, 65);
            this.BTN_soustraction.TabIndex = 28;
            this.BTN_soustraction.Text = "-";
            this.BTN_soustraction.UseVisualStyleBackColor = true;
            this.BTN_soustraction.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // BTN_multiplication
            // 
            this.BTN_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_multiplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_multiplication.Location = new System.Drawing.Point(281, 133);
            this.BTN_multiplication.Name = "BTN_multiplication";
            this.BTN_multiplication.Size = new System.Drawing.Size(65, 65);
            this.BTN_multiplication.TabIndex = 29;
            this.BTN_multiplication.Text = "*";
            this.BTN_multiplication.UseVisualStyleBackColor = true;
            this.BTN_multiplication.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // BTN_division
            // 
            this.BTN_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_division.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_division.Location = new System.Drawing.Point(281, 62);
            this.BTN_division.Name = "BTN_division";
            this.BTN_division.Size = new System.Drawing.Size(65, 65);
            this.BTN_division.TabIndex = 30;
            this.BTN_division.Text = "/";
            this.BTN_division.UseVisualStyleBackColor = true;
            this.BTN_division.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // BTN_virgule1
            // 
            this.BTN_virgule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_virgule1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_virgule1.Location = new System.Drawing.Point(210, 346);
            this.BTN_virgule1.Name = "BTN_virgule1";
            this.BTN_virgule1.Size = new System.Drawing.Size(65, 65);
            this.BTN_virgule1.TabIndex = 31;
            this.BTN_virgule1.Text = ",";
            this.BTN_virgule1.UseVisualStyleBackColor = true;
            this.BTN_virgule1.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // BTN_negatif
            // 
            this.BTN_negatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_negatif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_negatif.Location = new System.Drawing.Point(68, 346);
            this.BTN_negatif.Name = "BTN_negatif";
            this.BTN_negatif.Size = new System.Drawing.Size(65, 65);
            this.BTN_negatif.TabIndex = 33;
            this.BTN_negatif.Text = "(-)";
            this.BTN_negatif.UseVisualStyleBackColor = true;
            this.BTN_negatif.Click += new System.EventHandler(this.BTN_chiffre);
            // 
            // btnPuissance
            // 
            this.btnPuissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuissance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPuissance.Location = new System.Drawing.Point(68, 62);
            this.btnPuissance.Name = "btnPuissance";
            this.btnPuissance.Size = new System.Drawing.Size(65, 65);
            this.btnPuissance.TabIndex = 34;
            this.btnPuissance.Text = "^";
            this.btnPuissance.UseVisualStyleBackColor = true;
            this.btnPuissance.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mod.Location = new System.Drawing.Point(139, 62);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(65, 65);
            this.mod.TabIndex = 35;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.BTN_operateur);
            // 
            // FM_Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 451);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.btnPuissance);
            this.Controls.Add(this.BTN_negatif);
            this.Controls.Add(this.BTN_virgule1);
            this.Controls.Add(this.BTN_division);
            this.Controls.Add(this.BTN_multiplication);
            this.Controls.Add(this.BTN_soustraction);
            this.Controls.Add(this.TXT_champs);
            this.Controls.Add(this.BTN_reset);
            this.Controls.Add(this.BTN_result);
            this.Controls.Add(this.BTN_addition);
            this.Controls.Add(this.BTN_9);
            this.Controls.Add(this.BTN_8);
            this.Controls.Add(this.BTN_7);
            this.Controls.Add(this.BTN_6);
            this.Controls.Add(this.BTN_5);
            this.Controls.Add(this.BTN_4);
            this.Controls.Add(this.BTN_3);
            this.Controls.Add(this.BTN_1);
            this.Controls.Add(this.BTN_2);
            this.Controls.Add(this.BTN_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FM_Calculatrice";
            this.ShowIcon = false;
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BTN_reset;
        internal System.Windows.Forms.Button BTN_result;
        internal System.Windows.Forms.Button BTN_addition;
        internal System.Windows.Forms.Button BTN_9;
        internal System.Windows.Forms.Button BTN_8;
        internal System.Windows.Forms.Button BTN_7;
        internal System.Windows.Forms.Button BTN_6;
        internal System.Windows.Forms.Button BTN_5;
        internal System.Windows.Forms.Button BTN_4;
        internal System.Windows.Forms.Button BTN_3;
        internal System.Windows.Forms.Button BTN_1;
        internal System.Windows.Forms.Button BTN_2;
        internal System.Windows.Forms.Button BTN_0;
        internal System.Windows.Forms.TextBox TXT_champs;
        internal System.Windows.Forms.Button BTN_soustraction;
        internal System.Windows.Forms.Button BTN_multiplication;
        internal System.Windows.Forms.Button BTN_division;
        internal System.Windows.Forms.Button BTN_virgule1;
        internal System.Windows.Forms.Button BTN_negatif;
        internal System.Windows.Forms.Button btnPuissance;
        internal System.Windows.Forms.Button mod;
    }
}

