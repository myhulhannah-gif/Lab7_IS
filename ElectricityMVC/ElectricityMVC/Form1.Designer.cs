namespace ElectricityMVC
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
            txtPower = new TextBox();
            txtHours = new TextBox();
            txtTariff = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtPower
            // 
            txtPower.Location = new Point(145, 48);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(125, 27);
            txtPower.TabIndex = 0;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(145, 119);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 1;
            // 
            // txtTariff
            // 
            txtTariff.Location = new Point(145, 195);
            txtTariff.Name = "txtTariff";
            txtTariff.Size = new Size(125, 27);
            txtTariff.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(348, 86);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(128, 29);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Розрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(332, 172);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Вартість:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "Потужність";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 122);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 6;
            label2.Text = "Час";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 198);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Тариф";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtTariff);
            Controls.Add(txtHours);
            Controls.Add(txtPower);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPower;
        private TextBox txtHours;
        private TextBox txtTariff;
        private Button btnCalculate;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
