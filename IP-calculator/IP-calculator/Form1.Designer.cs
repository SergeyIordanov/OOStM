namespace IP_calculator
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxIP1 = new System.Windows.Forms.TextBox();
            this.labelIPError = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP2 = new System.Windows.Forms.TextBox();
            this.textBoxIP3 = new System.Windows.Forms.TextBox();
            this.textBoxIP4 = new System.Windows.Forms.TextBox();
            this.labelDot1 = new System.Windows.Forms.Label();
            this.labelDot3 = new System.Windows.Forms.Label();
            this.labelDot2 = new System.Windows.Forms.Label();
            this.textBoxMask4 = new System.Windows.Forms.TextBox();
            this.textBoxMask3 = new System.Windows.Forms.TextBox();
            this.textBoxMask2 = new System.Windows.Forms.TextBox();
            this.labelMask = new System.Windows.Forms.Label();
            this.labelMaskError = new System.Windows.Forms.Label();
            this.textBoxMask1 = new System.Windows.Forms.TextBox();
            this.labelDotMask1 = new System.Windows.Forms.Label();
            this.labelDotMask2 = new System.Windows.Forms.Label();
            this.labelDotMask3 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.labelBitmask = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaxHost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMinHost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHosts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelBroadcast = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownSubnets = new System.Windows.Forms.NumericUpDown();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.richTextBoxSubnets = new System.Windows.Forms.RichTextBox();
            this.labelMaxSubnets = new System.Windows.Forms.Label();
            this.labelNetworkBits = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNode = new System.Windows.Forms.Label();
            this.labelMaxHostBits = new System.Windows.Forms.Label();
            this.labelMinHostBits = new System.Windows.Forms.Label();
            this.labelBroadcastBits = new System.Windows.Forms.Label();
            this.labelIPBits = new System.Windows.Forms.Label();
            this.labelMaskBits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubnets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.Location = new System.Drawing.Point(229, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(224, 42);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "IP-calculator";
            // 
            // textBoxIP1
            // 
            this.textBoxIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP1.Location = new System.Drawing.Point(16, 117);
            this.textBoxIP1.Name = "textBoxIP1";
            this.textBoxIP1.Size = new System.Drawing.Size(54, 26);
            this.textBoxIP1.TabIndex = 1;
            this.textBoxIP1.Text = "0";
            this.textBoxIP1.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // labelIPError
            // 
            this.labelIPError.AutoSize = true;
            this.labelIPError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIPError.ForeColor = System.Drawing.Color.Red;
            this.labelIPError.Location = new System.Drawing.Point(214, 97);
            this.labelIPError.Name = "labelIPError";
            this.labelIPError.Size = new System.Drawing.Size(71, 15);
            this.labelIPError.TabIndex = 3;
            this.labelIPError.Text = "Errors here!";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIP.Location = new System.Drawing.Point(12, 94);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(196, 20);
            this.labelIP.TabIndex = 7;
            this.labelIP.Text = "IP-address (host address):";
            // 
            // textBoxIP2
            // 
            this.textBoxIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP2.Location = new System.Drawing.Point(80, 117);
            this.textBoxIP2.Name = "textBoxIP2";
            this.textBoxIP2.Size = new System.Drawing.Size(54, 26);
            this.textBoxIP2.TabIndex = 8;
            this.textBoxIP2.Text = "0";
            this.textBoxIP2.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // textBoxIP3
            // 
            this.textBoxIP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP3.Location = new System.Drawing.Point(144, 117);
            this.textBoxIP3.Name = "textBoxIP3";
            this.textBoxIP3.Size = new System.Drawing.Size(54, 26);
            this.textBoxIP3.TabIndex = 9;
            this.textBoxIP3.Text = "0";
            this.textBoxIP3.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // textBoxIP4
            // 
            this.textBoxIP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP4.Location = new System.Drawing.Point(208, 117);
            this.textBoxIP4.Name = "textBoxIP4";
            this.textBoxIP4.Size = new System.Drawing.Size(54, 26);
            this.textBoxIP4.TabIndex = 10;
            this.textBoxIP4.Text = "0";
            this.textBoxIP4.TextChanged += new System.EventHandler(this.textBoxIP_TextChanged);
            // 
            // labelDot1
            // 
            this.labelDot1.AutoSize = true;
            this.labelDot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDot1.Location = new System.Drawing.Point(67, 122);
            this.labelDot1.Name = "labelDot1";
            this.labelDot1.Size = new System.Drawing.Size(16, 24);
            this.labelDot1.TabIndex = 11;
            this.labelDot1.Text = ".";
            // 
            // labelDot3
            // 
            this.labelDot3.AutoSize = true;
            this.labelDot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDot3.Location = new System.Drawing.Point(196, 122);
            this.labelDot3.Name = "labelDot3";
            this.labelDot3.Size = new System.Drawing.Size(16, 24);
            this.labelDot3.TabIndex = 13;
            this.labelDot3.Text = ".";
            // 
            // labelDot2
            // 
            this.labelDot2.AutoSize = true;
            this.labelDot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDot2.Location = new System.Drawing.Point(131, 122);
            this.labelDot2.Name = "labelDot2";
            this.labelDot2.Size = new System.Drawing.Size(16, 24);
            this.labelDot2.TabIndex = 14;
            this.labelDot2.Text = ".";
            // 
            // textBoxMask4
            // 
            this.textBoxMask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMask4.Location = new System.Drawing.Point(208, 204);
            this.textBoxMask4.Name = "textBoxMask4";
            this.textBoxMask4.Size = new System.Drawing.Size(54, 26);
            this.textBoxMask4.TabIndex = 20;
            this.textBoxMask4.Text = "0";
            this.textBoxMask4.TextChanged += new System.EventHandler(this.textBoxMask_TextChanged);
            // 
            // textBoxMask3
            // 
            this.textBoxMask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMask3.Location = new System.Drawing.Point(144, 204);
            this.textBoxMask3.Name = "textBoxMask3";
            this.textBoxMask3.Size = new System.Drawing.Size(54, 26);
            this.textBoxMask3.TabIndex = 19;
            this.textBoxMask3.Text = "255";
            this.textBoxMask3.TextChanged += new System.EventHandler(this.textBoxMask_TextChanged);
            // 
            // textBoxMask2
            // 
            this.textBoxMask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMask2.Location = new System.Drawing.Point(80, 204);
            this.textBoxMask2.Name = "textBoxMask2";
            this.textBoxMask2.Size = new System.Drawing.Size(54, 26);
            this.textBoxMask2.TabIndex = 18;
            this.textBoxMask2.Text = "255";
            this.textBoxMask2.TextChanged += new System.EventHandler(this.textBoxMask_TextChanged);
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMask.Location = new System.Drawing.Point(12, 181);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(80, 20);
            this.labelMask.TabIndex = 17;
            this.labelMask.Text = "Net mask:";
            // 
            // labelMaskError
            // 
            this.labelMaskError.AutoSize = true;
            this.labelMaskError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaskError.ForeColor = System.Drawing.Color.Red;
            this.labelMaskError.Location = new System.Drawing.Point(98, 184);
            this.labelMaskError.Name = "labelMaskError";
            this.labelMaskError.Size = new System.Drawing.Size(71, 15);
            this.labelMaskError.TabIndex = 16;
            this.labelMaskError.Text = "Errors here!";
            // 
            // textBoxMask1
            // 
            this.textBoxMask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMask1.Location = new System.Drawing.Point(16, 204);
            this.textBoxMask1.Name = "textBoxMask1";
            this.textBoxMask1.Size = new System.Drawing.Size(54, 26);
            this.textBoxMask1.TabIndex = 15;
            this.textBoxMask1.Text = "255";
            this.textBoxMask1.TextChanged += new System.EventHandler(this.textBoxMask_TextChanged);
            // 
            // labelDotMask1
            // 
            this.labelDotMask1.AutoSize = true;
            this.labelDotMask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotMask1.Location = new System.Drawing.Point(67, 209);
            this.labelDotMask1.Name = "labelDotMask1";
            this.labelDotMask1.Size = new System.Drawing.Size(16, 24);
            this.labelDotMask1.TabIndex = 21;
            this.labelDotMask1.Text = ".";
            // 
            // labelDotMask2
            // 
            this.labelDotMask2.AutoSize = true;
            this.labelDotMask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotMask2.Location = new System.Drawing.Point(131, 209);
            this.labelDotMask2.Name = "labelDotMask2";
            this.labelDotMask2.Size = new System.Drawing.Size(16, 24);
            this.labelDotMask2.TabIndex = 23;
            this.labelDotMask2.Text = ".";
            // 
            // labelDotMask3
            // 
            this.labelDotMask3.AutoSize = true;
            this.labelDotMask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDotMask3.Location = new System.Drawing.Point(196, 209);
            this.labelDotMask3.Name = "labelDotMask3";
            this.labelDotMask3.Size = new System.Drawing.Size(16, 24);
            this.labelDotMask3.TabIndex = 22;
            this.labelDotMask3.Text = ".";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResults.Location = new System.Drawing.Point(12, 268);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(76, 24);
            this.labelResults.TabIndex = 24;
            this.labelResults.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Network:";
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNetwork.Location = new System.Drawing.Point(104, 300);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(57, 20);
            this.labelNetwork.TabIndex = 28;
            this.labelNetwork.Text = "0.0.0.0";
            // 
            // labelBitmask
            // 
            this.labelBitmask.AutoSize = true;
            this.labelBitmask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBitmask.Location = new System.Drawing.Point(104, 388);
            this.labelBitmask.Name = "labelBitmask";
            this.labelBitmask.Size = new System.Drawing.Size(27, 20);
            this.labelBitmask.TabIndex = 30;
            this.labelBitmask.Text = "24";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bitmask:";
            // 
            // labelMaxHost
            // 
            this.labelMaxHost.AutoSize = true;
            this.labelMaxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxHost.Location = new System.Drawing.Point(104, 476);
            this.labelMaxHost.Name = "labelMaxHost";
            this.labelMaxHost.Size = new System.Drawing.Size(75, 20);
            this.labelMaxHost.TabIndex = 32;
            this.labelMaxHost.Text = "0.0.0.254";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Max host:";
            // 
            // labelMinHost
            // 
            this.labelMinHost.AutoSize = true;
            this.labelMinHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinHost.Location = new System.Drawing.Point(104, 420);
            this.labelMinHost.Name = "labelMinHost";
            this.labelMinHost.Size = new System.Drawing.Size(57, 20);
            this.labelMinHost.TabIndex = 34;
            this.labelMinHost.Text = "0.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Min host:";
            // 
            // labelHosts
            // 
            this.labelHosts.AutoSize = true;
            this.labelHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHosts.Location = new System.Drawing.Point(104, 532);
            this.labelHosts.Name = "labelHosts";
            this.labelHosts.Size = new System.Drawing.Size(36, 20);
            this.labelHosts.TabIndex = 36;
            this.labelHosts.Text = "254";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Hosts:";
            // 
            // labelBroadcast
            // 
            this.labelBroadcast.AutoSize = true;
            this.labelBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBroadcast.Location = new System.Drawing.Point(104, 564);
            this.labelBroadcast.Name = "labelBroadcast";
            this.labelBroadcast.Size = new System.Drawing.Size(75, 20);
            this.labelBroadcast.TabIndex = 38;
            this.labelBroadcast.Text = "0.0.0.255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Broadcast:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(469, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Subnetting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(380, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Subnets:";
            // 
            // numericUpDownSubnets
            // 
            this.numericUpDownSubnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSubnets.Location = new System.Drawing.Point(459, 127);
            this.numericUpDownSubnets.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownSubnets.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSubnets.Name = "numericUpDownSubnets";
            this.numericUpDownSubnets.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownSubnets.TabIndex = 41;
            this.numericUpDownSubnets.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(541, 126);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(138, 45);
            this.buttonDivide.TabIndex = 42;
            this.buttonDivide.Text = "Divide";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // richTextBoxSubnets
            // 
            this.richTextBoxSubnets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSubnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSubnets.Location = new System.Drawing.Point(384, 184);
            this.richTextBoxSubnets.Name = "richTextBoxSubnets";
            this.richTextBoxSubnets.Size = new System.Drawing.Size(295, 420);
            this.richTextBoxSubnets.TabIndex = 43;
            this.richTextBoxSubnets.Text = "";
            // 
            // labelMaxSubnets
            // 
            this.labelMaxSubnets.AutoSize = true;
            this.labelMaxSubnets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxSubnets.Location = new System.Drawing.Point(419, 155);
            this.labelMaxSubnets.Name = "labelMaxSubnets";
            this.labelMaxSubnets.Size = new System.Drawing.Size(68, 16);
            this.labelMaxSubnets.TabIndex = 44;
            this.labelMaxSubnets.Text = "(max: 128)";
            // 
            // labelNetworkBits
            // 
            this.labelNetworkBits.AutoSize = true;
            this.labelNetworkBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNetworkBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelNetworkBits.Location = new System.Drawing.Point(12, 320);
            this.labelNetworkBits.Name = "labelNetworkBits";
            this.labelNetworkBits.Size = new System.Drawing.Size(325, 20);
            this.labelNetworkBits.TabIndex = 45;
            this.labelNetworkBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Node num:";
            // 
            // labelNode
            // 
            this.labelNode.AutoSize = true;
            this.labelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNode.Location = new System.Drawing.Point(104, 356);
            this.labelNode.Name = "labelNode";
            this.labelNode.Size = new System.Drawing.Size(164, 20);
            this.labelNode.TabIndex = 47;
            this.labelNode.Text = "null (network address)";
            // 
            // labelMaxHostBits
            // 
            this.labelMaxHostBits.AutoSize = true;
            this.labelMaxHostBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxHostBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelMaxHostBits.Location = new System.Drawing.Point(12, 496);
            this.labelMaxHostBits.Name = "labelMaxHostBits";
            this.labelMaxHostBits.Size = new System.Drawing.Size(325, 20);
            this.labelMaxHostBits.TabIndex = 48;
            this.labelMaxHostBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // labelMinHostBits
            // 
            this.labelMinHostBits.AutoSize = true;
            this.labelMinHostBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinHostBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelMinHostBits.Location = new System.Drawing.Point(12, 440);
            this.labelMinHostBits.Name = "labelMinHostBits";
            this.labelMinHostBits.Size = new System.Drawing.Size(325, 20);
            this.labelMinHostBits.TabIndex = 49;
            this.labelMinHostBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // labelBroadcastBits
            // 
            this.labelBroadcastBits.AutoSize = true;
            this.labelBroadcastBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBroadcastBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelBroadcastBits.Location = new System.Drawing.Point(11, 584);
            this.labelBroadcastBits.Name = "labelBroadcastBits";
            this.labelBroadcastBits.Size = new System.Drawing.Size(325, 20);
            this.labelBroadcastBits.TabIndex = 50;
            this.labelBroadcastBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // labelIPBits
            // 
            this.labelIPBits.AutoSize = true;
            this.labelIPBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIPBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelIPBits.Location = new System.Drawing.Point(14, 146);
            this.labelIPBits.Name = "labelIPBits";
            this.labelIPBits.Size = new System.Drawing.Size(325, 20);
            this.labelIPBits.TabIndex = 51;
            this.labelIPBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // labelMaskBits
            // 
            this.labelMaskBits.AutoSize = true;
            this.labelMaskBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaskBits.ForeColor = System.Drawing.Color.DimGray;
            this.labelMaskBits.Location = new System.Drawing.Point(14, 233);
            this.labelMaskBits.Name = "labelMaskBits";
            this.labelMaskBits.Size = new System.Drawing.Size(325, 20);
            this.labelMaskBits.TabIndex = 52;
            this.labelMaskBits.Text = "0000 0000.0000 0000.0000 0000.0000 0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 633);
            this.Controls.Add(this.labelMaskBits);
            this.Controls.Add(this.labelIPBits);
            this.Controls.Add(this.labelBroadcastBits);
            this.Controls.Add(this.labelMinHostBits);
            this.Controls.Add(this.labelMaxHostBits);
            this.Controls.Add(this.labelNode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelNetworkBits);
            this.Controls.Add(this.labelMaxSubnets);
            this.Controls.Add(this.richTextBoxSubnets);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.numericUpDownSubnets);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelBroadcast);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelHosts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelMinHost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMaxHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBitmask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNetwork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxMask4);
            this.Controls.Add(this.textBoxMask3);
            this.Controls.Add(this.textBoxMask2);
            this.Controls.Add(this.labelMask);
            this.Controls.Add(this.labelMaskError);
            this.Controls.Add(this.textBoxMask1);
            this.Controls.Add(this.labelDotMask1);
            this.Controls.Add(this.labelDotMask2);
            this.Controls.Add(this.labelDotMask3);
            this.Controls.Add(this.textBoxIP4);
            this.Controls.Add(this.textBoxIP3);
            this.Controls.Add(this.textBoxIP2);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelIPError);
            this.Controls.Add(this.textBoxIP1);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelDot1);
            this.Controls.Add(this.labelDot2);
            this.Controls.Add(this.labelDot3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP-calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubnets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.TextBox textBoxIP1;
        private System.Windows.Forms.Label labelIPError;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP2;
        private System.Windows.Forms.TextBox textBoxIP3;
        private System.Windows.Forms.TextBox textBoxIP4;
        private System.Windows.Forms.Label labelDot1;
        private System.Windows.Forms.Label labelDot3;
        private System.Windows.Forms.Label labelDot2;
        private System.Windows.Forms.TextBox textBoxMask4;
        private System.Windows.Forms.TextBox textBoxMask3;
        private System.Windows.Forms.TextBox textBoxMask2;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.Label labelMaskError;
        private System.Windows.Forms.TextBox textBoxMask1;
        private System.Windows.Forms.Label labelDotMask1;
        private System.Windows.Forms.Label labelDotMask2;
        private System.Windows.Forms.Label labelDotMask3;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.Label labelBitmask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaxHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMinHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHosts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelBroadcast;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownSubnets;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.RichTextBox richTextBoxSubnets;
        private System.Windows.Forms.Label labelMaxSubnets;
        private System.Windows.Forms.Label labelNetworkBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNode;
        private System.Windows.Forms.Label labelMaxHostBits;
        private System.Windows.Forms.Label labelMinHostBits;
        private System.Windows.Forms.Label labelBroadcastBits;
        private System.Windows.Forms.Label labelIPBits;
        private System.Windows.Forms.Label labelMaskBits;
    }
}

