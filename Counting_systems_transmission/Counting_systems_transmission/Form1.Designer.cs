namespace Counting_systems_transmission
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
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.radioButtonBitwise = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplication = new System.Windows.Forms.RadioButton();
            this.radioButtonTable = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonCombination = new System.Windows.Forms.RadioButton();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "BIN (2)",
            "OCT (8)",
            "DEC (10)",
            "HEX (16)"});
            this.comboBoxFrom.Location = new System.Drawing.Point(62, 93);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(180, 28);
            this.comboBoxFrom.TabIndex = 0;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "BIN (2)",
            "OCT (8)",
            "DEC (10)",
            "HEX (16)"});
            this.comboBoxTo.Location = new System.Drawing.Point(431, 93);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(180, 28);
            this.comboBoxTo.TabIndex = 1;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(59, 74);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(42, 16);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(428, 74);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 16);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To:";
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnter.Location = new System.Drawing.Point(62, 199);
            this.textBoxEnter.MaxLength = 20;
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(180, 26);
            this.textBoxEnter.TabIndex = 4;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.textBoxEnter_TextChanged);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(59, 180);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(111, 16);
            this.labelEnter.TabIndex = 5;
            this.labelEnter.Text = "Enter the number:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(428, 180);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 16);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(431, 199);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(180, 26);
            this.textBoxResult.TabIndex = 7;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.Location = new System.Drawing.Point(275, 74);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(127, 16);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Choose the method:";
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(297, 116);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDivision.TabIndex = 10;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSubtraction
            // 
            this.radioButtonSubtraction.AutoSize = true;
            this.radioButtonSubtraction.Checked = true;
            this.radioButtonSubtraction.Location = new System.Drawing.Point(297, 93);
            this.radioButtonSubtraction.Name = "radioButtonSubtraction";
            this.radioButtonSubtraction.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSubtraction.TabIndex = 11;
            this.radioButtonSubtraction.TabStop = true;
            this.radioButtonSubtraction.Text = "Subtraction";
            this.radioButtonSubtraction.UseVisualStyleBackColor = true;
            this.radioButtonSubtraction.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonBitwise
            // 
            this.radioButtonBitwise.AutoSize = true;
            this.radioButtonBitwise.Location = new System.Drawing.Point(297, 162);
            this.radioButtonBitwise.Name = "radioButtonBitwise";
            this.radioButtonBitwise.Size = new System.Drawing.Size(58, 17);
            this.radioButtonBitwise.TabIndex = 12;
            this.radioButtonBitwise.Text = "Bitwise";
            this.radioButtonBitwise.UseVisualStyleBackColor = true;
            this.radioButtonBitwise.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonMultiplication
            // 
            this.radioButtonMultiplication.AutoSize = true;
            this.radioButtonMultiplication.Location = new System.Drawing.Point(297, 139);
            this.radioButtonMultiplication.Name = "radioButtonMultiplication";
            this.radioButtonMultiplication.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMultiplication.TabIndex = 13;
            this.radioButtonMultiplication.Text = "Multiplication";
            this.radioButtonMultiplication.UseVisualStyleBackColor = true;
            this.radioButtonMultiplication.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonTable
            // 
            this.radioButtonTable.AutoSize = true;
            this.radioButtonTable.Location = new System.Drawing.Point(297, 185);
            this.radioButtonTable.Name = "radioButtonTable";
            this.radioButtonTable.Size = new System.Drawing.Size(52, 17);
            this.radioButtonTable.TabIndex = 14;
            this.radioButtonTable.Text = "Table";
            this.radioButtonTable.UseVisualStyleBackColor = true;
            this.radioButtonTable.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(117, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(339, 31);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Number systems translator";
            // 
            // radioButtonCombination
            // 
            this.radioButtonCombination.AutoSize = true;
            this.radioButtonCombination.Location = new System.Drawing.Point(297, 208);
            this.radioButtonCombination.Name = "radioButtonCombination";
            this.radioButtonCombination.Size = new System.Drawing.Size(83, 17);
            this.radioButtonCombination.TabIndex = 16;
            this.radioButtonCombination.Text = "Combination";
            this.radioButtonCombination.UseVisualStyleBackColor = true;
            this.radioButtonCombination.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(59, 228);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(99, 16);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Place for errors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 263);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.radioButtonCombination);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.radioButtonTable);
            this.Controls.Add(this.radioButtonMultiplication);
            this.Controls.Add(this.radioButtonBitwise);
            this.Controls.Add(this.radioButtonSubtraction);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Name = "Form1";
            this.Text = "Number systems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonSubtraction;
        private System.Windows.Forms.RadioButton radioButtonBitwise;
        private System.Windows.Forms.RadioButton radioButtonMultiplication;
        private System.Windows.Forms.RadioButton radioButtonTable;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonCombination;
        private System.Windows.Forms.Label labelError;
    }
}

