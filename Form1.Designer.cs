namespace VS2026Handbook_Chapter14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lblTotal = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(261, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(189, 27);
            txtPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(261, 173);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(189, 27);
            txtQuantity.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(263, 225);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(271, 275);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(180, 41);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lblTotal;
        private Button btnCalculate;
    }
}
