
namespace WindowsFormsApp1.Vistas
{
    partial class FrmMultiplicacion
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
            this.TxtR = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtR
            // 
            this.TxtR.Location = new System.Drawing.Point(219, 289);
            this.TxtR.Name = "TxtR";
            this.TxtR.Size = new System.Drawing.Size(159, 26);
            this.TxtR.TabIndex = 11;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(485, 289);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(100, 33);
            this.Calc.TabIndex = 10;
            this.Calc.Text = "Calcular";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escriba el segundo valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escriba el primer valor";
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(485, 217);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 26);
            this.TxtNum2.TabIndex = 7;
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(485, 129);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 26);
            this.TxtNum1.TabIndex = 6;
            // 
            // FrmMultiplicacion
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
            this.Name = "FrmMultiplicacion";
            this.Text = "FrmMultiplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtR;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtNum1;
    }
}