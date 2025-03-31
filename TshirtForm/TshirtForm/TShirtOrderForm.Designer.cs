namespace TshirtForm
{
    partial class TShirtOrderForm
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
            this.txtNumberOfTShirts = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOfTShirts
            // 
            this.txtNumberOfTShirts.Location = new System.Drawing.Point(26, 43);
            this.txtNumberOfTShirts.Name = "txtNumberOfTShirts";
            this.txtNumberOfTShirts.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfTShirts.TabIndex = 0;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbSize.Location = new System.Drawing.Point(152, 43);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 24);
            this.cmbSize.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(303, 44);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(23, 105);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(120, 16);
            this.lblFinalPrice.TabIndex = 3;
            this.lblFinalPrice.Text = "Final Price: Rs 0.00";
            this.lblFinalPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // TShirtOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtNumberOfTShirts);
            this.Name = "TShirtOrderForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfTShirts;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinalPrice;
    }
}

