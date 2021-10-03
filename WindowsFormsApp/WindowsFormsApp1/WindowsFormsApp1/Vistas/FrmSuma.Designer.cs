
namespace WindowsFormsApp1.Vistas
{
    partial class FrmSuma
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
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.TxtR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(485, 97);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 26);
            this.TxtNum1.TabIndex = 0;
            this.TxtNum1.TextChanged += new System.EventHandler(this.TxtNum1_TextChanged);
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(485, 185);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 26);
            this.TxtNum2.TabIndex = 1;
            this.TxtNum2.TextChanged += new System.EventHandler(this.TxtNum2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba el primer valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escriba el segundo valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(485, 257);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(100, 33);
            this.Calc.TabIndex = 4;
            this.Calc.Text = "Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // TxtR
            // 
            this.TxtR.Location = new System.Drawing.Point(219, 257);
            this.TxtR.Name = "TxtR";
            this.TxtR.Size = new System.Drawing.Size(177, 26);
            this.TxtR.TabIndex = 5;
            this.TxtR.TextChanged += new System.EventHandler(this.TxtR_TextChanged);
            // 
            // FrmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtR);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Name = "FrmSuma";
            this.Text = "FrmSuma";
            this.Load += new System.EventHandler(this.FrmSuma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox TxtR;
    }
}