namespace StarScreen
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LifeTimeUnD = new System.Windows.Forms.NumericUpDown();
			this.SizeUnD = new System.Windows.Forms.NumericUpDown();
			this.SpeedUnD = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DensityUnD = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.MaxLengthUnD = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.CreateConecionsChB = new System.Windows.Forms.CheckBox();
			this.OkBtn = new System.Windows.Forms.Button();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LifeTimeUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DensityUnD)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxLengthUnD)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.LifeTimeUnD);
			this.groupBox1.Controls.Add(this.SizeUnD);
			this.groupBox1.Controls.Add(this.SpeedUnD);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.DensityUnD);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 132);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Star";
			// 
			// LifeTimeUnD
			// 
			this.LifeTimeUnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LifeTimeUnD.Location = new System.Drawing.Point(109, 102);
			this.LifeTimeUnD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.LifeTimeUnD.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.LifeTimeUnD.Name = "LifeTimeUnD";
			this.LifeTimeUnD.Size = new System.Drawing.Size(95, 20);
			this.LifeTimeUnD.TabIndex = 7;
			this.LifeTimeUnD.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.LifeTimeUnD.ValueChanged += new System.EventHandler(this.LifeTimeUnD_ValueChanged);
			// 
			// SizeUnD
			// 
			this.SizeUnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SizeUnD.Location = new System.Drawing.Point(109, 46);
			this.SizeUnD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.SizeUnD.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.SizeUnD.Name = "SizeUnD";
			this.SizeUnD.Size = new System.Drawing.Size(95, 20);
			this.SizeUnD.TabIndex = 3;
			this.SizeUnD.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.SizeUnD.ValueChanged += new System.EventHandler(this.SizeUnD_ValueChanged);
			// 
			// SpeedUnD
			// 
			this.SpeedUnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SpeedUnD.Location = new System.Drawing.Point(109, 74);
			this.SpeedUnD.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.SpeedUnD.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.SpeedUnD.Name = "SpeedUnD";
			this.SpeedUnD.Size = new System.Drawing.Size(95, 20);
			this.SpeedUnD.TabIndex = 5;
			this.SpeedUnD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.SpeedUnD.ValueChanged += new System.EventHandler(this.SpeedUnD_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Life time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Twinkling speed";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Size";
			// 
			// DensityUnD
			// 
			this.DensityUnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DensityUnD.Location = new System.Drawing.Point(109, 18);
			this.DensityUnD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.DensityUnD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DensityUnD.Name = "DensityUnD";
			this.DensityUnD.Size = new System.Drawing.Size(95, 20);
			this.DensityUnD.TabIndex = 1;
			this.DensityUnD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DensityUnD.ValueChanged += new System.EventHandler(this.DensityUnD_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Density";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.MaxLengthUnD);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.CreateConecionsChB);
			this.groupBox2.Location = new System.Drawing.Point(12, 150);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 78);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Conections";
			// 
			// MaxLengthUnD
			// 
			this.MaxLengthUnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MaxLengthUnD.Location = new System.Drawing.Point(109, 46);
			this.MaxLengthUnD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.MaxLengthUnD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.MaxLengthUnD.Name = "MaxLengthUnD";
			this.MaxLengthUnD.Size = new System.Drawing.Size(95, 20);
			this.MaxLengthUnD.TabIndex = 2;
			this.MaxLengthUnD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.MaxLengthUnD.ValueChanged += new System.EventHandler(this.MaxLengthUnD_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Max length";
			// 
			// CreateConecionsChB
			// 
			this.CreateConecionsChB.AutoSize = true;
			this.CreateConecionsChB.Location = new System.Drawing.Point(6, 19);
			this.CreateConecionsChB.Name = "CreateConecionsChB";
			this.CreateConecionsChB.Size = new System.Drawing.Size(112, 17);
			this.CreateConecionsChB.TabIndex = 0;
			this.CreateConecionsChB.Text = "Create conections";
			this.CreateConecionsChB.UseVisualStyleBackColor = true;
			this.CreateConecionsChB.CheckedChanged += new System.EventHandler(this.CreateConecionsChB_CheckedChanged);
			// 
			// OkBtn
			// 
			this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkBtn.Location = new System.Drawing.Point(147, 239);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(75, 23);
			this.OkBtn.TabIndex = 2;
			this.OkBtn.Text = "Ok";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
			// 
			// ResetBtn
			// 
			this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ResetBtn.Location = new System.Drawing.Point(13, 239);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new System.Drawing.Size(75, 23);
			this.ResetBtn.TabIndex = 3;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
			// 
			// Form2
			// 
			this.AcceptButton = this.OkBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 274);
			this.Controls.Add(this.ResetBtn);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StarScreen";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LifeTimeUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DensityUnD)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxLengthUnD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown DensityUnD;
		private System.Windows.Forms.NumericUpDown LifeTimeUnD;
		private System.Windows.Forms.NumericUpDown SizeUnD;
		private System.Windows.Forms.NumericUpDown SpeedUnD;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox CreateConecionsChB;
		private System.Windows.Forms.NumericUpDown MaxLengthUnD;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.Button ResetBtn;
	}
}