namespace ElectricityMVP
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
            btnCalculate = new Button();
            lblResult = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPower = new TextBox();
            txtHours = new TextBox();
            txtTariff = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(353, 85);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(121, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(353, 164);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Вартість:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 61);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Потужність";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 125);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 3;
            label3.Text = "Час";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 196);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Тариф";
            // 
            // txtPower
            // 
            txtPower.Location = new Point(152, 58);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(125, 27);
            txtPower.TabIndex = 5;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(152, 122);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 6;
            // 
            // txtTariff
            // 
            txtTariff.Location = new Point(152, 193);
            txtTariff.Name = "txtTariff";
            txtTariff.Size = new Size(125, 27);
            txtTariff.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 259);
            Controls.Add(txtTariff);
            Controls.Add(txtHours);
            Controls.Add(txtPower);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPower;
        private TextBox txtHours;
        private TextBox txtTariff;
    }
}
