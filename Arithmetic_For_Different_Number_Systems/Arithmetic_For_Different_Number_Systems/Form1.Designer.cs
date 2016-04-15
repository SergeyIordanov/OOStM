namespace Arithmetic_For_Different_Number_Systems
{
    partial class Form1
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
            this.labelErrorFirst = new System.Windows.Forms.Label();
            this.labelFirstOperand = new System.Windows.Forms.Label();
            this.textBoxFirstOperand = new System.Windows.Forms.TextBox();
            this.labelErrorSecond = new System.Windows.Forms.Label();
            this.labelSecondOperand = new System.Windows.Forms.Label();
            this.textBoxSecondOperand = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxNumberSystem = new System.Windows.Forms.ComboBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.labelNumderSystem = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErrorFirst
            // 
            this.labelErrorFirst.AutoSize = true;
            this.labelErrorFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorFirst.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFirst.Location = new System.Drawing.Point(12, 128);
            this.labelErrorFirst.Name = "labelErrorFirst";
            this.labelErrorFirst.Size = new System.Drawing.Size(109, 16);
            this.labelErrorFirst.TabIndex = 20;
            this.labelErrorFirst.Text = "Place for errors 1";
            // 
            // labelFirstOperand
            // 
            this.labelFirstOperand.AutoSize = true;
            this.labelFirstOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstOperand.Location = new System.Drawing.Point(12, 80);
            this.labelFirstOperand.Name = "labelFirstOperand";
            this.labelFirstOperand.Size = new System.Drawing.Size(112, 16);
            this.labelFirstOperand.TabIndex = 19;
            this.labelFirstOperand.Text = "The first operand:";
            // 
            // textBoxFirstOperand
            // 
            this.textBoxFirstOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstOperand.Location = new System.Drawing.Point(15, 99);
            this.textBoxFirstOperand.MaxLength = 20;
            this.textBoxFirstOperand.Name = "textBoxFirstOperand";
            this.textBoxFirstOperand.Size = new System.Drawing.Size(180, 26);
            this.textBoxFirstOperand.TabIndex = 18;
            this.textBoxFirstOperand.TextChanged += new System.EventHandler(this.textBoxFirstOperand_TextChanged);
            // 
            // labelErrorSecond
            // 
            this.labelErrorSecond.AutoSize = true;
            this.labelErrorSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorSecond.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSecond.Location = new System.Drawing.Point(12, 199);
            this.labelErrorSecond.Name = "labelErrorSecond";
            this.labelErrorSecond.Size = new System.Drawing.Size(109, 16);
            this.labelErrorSecond.TabIndex = 23;
            this.labelErrorSecond.Text = "Place for errors 2";
            // 
            // labelSecondOperand
            // 
            this.labelSecondOperand.AutoSize = true;
            this.labelSecondOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondOperand.Location = new System.Drawing.Point(12, 151);
            this.labelSecondOperand.Name = "labelSecondOperand";
            this.labelSecondOperand.Size = new System.Drawing.Size(137, 16);
            this.labelSecondOperand.TabIndex = 22;
            this.labelSecondOperand.Text = "The second operand:";
            // 
            // textBoxSecondOperand
            // 
            this.textBoxSecondOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondOperand.Location = new System.Drawing.Point(15, 170);
            this.textBoxSecondOperand.MaxLength = 20;
            this.textBoxSecondOperand.Name = "textBoxSecondOperand";
            this.textBoxSecondOperand.Size = new System.Drawing.Size(180, 26);
            this.textBoxSecondOperand.TabIndex = 21;
            this.textBoxSecondOperand.TextChanged += new System.EventHandler(this.textBoxFirstOperand_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(365, 139);
            this.textBoxResult.MaxLength = 30;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(180, 26);
            this.textBoxResult.TabIndex = 25;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(362, 120);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 16);
            this.labelResult.TabIndex = 24;
            this.labelResult.Text = "Result";
            // 
            // comboBoxNumberSystem
            // 
            this.comboBoxNumberSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberSystem.FormattingEnabled = true;
            this.comboBoxNumberSystem.Items.AddRange(new object[] {
            "BIN (2)",
            "OCT (8)",
            "DEC (10)",
            "HEX (16)"});
            this.comboBoxNumberSystem.Location = new System.Drawing.Point(207, 42);
            this.comboBoxNumberSystem.Name = "comboBoxNumberSystem";
            this.comboBoxNumberSystem.Size = new System.Drawing.Size(140, 28);
            this.comboBoxNumberSystem.TabIndex = 27;
            this.comboBoxNumberSystem.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberSystem_SelectedIndexChanged);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperation.Location = new System.Drawing.Point(246, 139);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(67, 28);
            this.comboBoxOperation.TabIndex = 26;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // labelNumderSystem
            // 
            this.labelNumderSystem.AutoSize = true;
            this.labelNumderSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumderSystem.Location = new System.Drawing.Point(204, 23);
            this.labelNumderSystem.Name = "labelNumderSystem";
            this.labelNumderSystem.Size = new System.Drawing.Size(143, 16);
            this.labelNumderSystem.TabIndex = 28;
            this.labelNumderSystem.Text = "Select number system:";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.Location = new System.Drawing.Point(243, 120);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(70, 16);
            this.labelOperation.TabIndex = 29;
            this.labelOperation.Text = "Operation:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(207, 214);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(140, 35);
            this.buttonCalculate.TabIndex = 30;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelNumderSystem);
            this.Controls.Add(this.comboBoxNumberSystem);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelErrorSecond);
            this.Controls.Add(this.labelSecondOperand);
            this.Controls.Add(this.textBoxSecondOperand);
            this.Controls.Add(this.labelErrorFirst);
            this.Controls.Add(this.labelFirstOperand);
            this.Controls.Add(this.textBoxFirstOperand);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorFirst;
        private System.Windows.Forms.Label labelFirstOperand;
        private System.Windows.Forms.TextBox textBoxFirstOperand;
        private System.Windows.Forms.Label labelErrorSecond;
        private System.Windows.Forms.Label labelSecondOperand;
        private System.Windows.Forms.TextBox textBoxSecondOperand;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxNumberSystem;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Label labelNumderSystem;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

