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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.GroupBoxStar = new System.Windows.Forms.GroupBox();
			this.LifeTimeUnD = new System.Windows.Forms.NumericUpDown();
			this.SizeUnD = new System.Windows.Forms.NumericUpDown();
			this.SpeedUnD = new System.Windows.Forms.NumericUpDown();
			this.LifeTimeLbl = new System.Windows.Forms.Label();
			this.SpeedLbl = new System.Windows.Forms.Label();
			this.SizeLbl = new System.Windows.Forms.Label();
			this.DensityUnD = new System.Windows.Forms.NumericUpDown();
			this.DensityLbl = new System.Windows.Forms.Label();
			this.GroupBoxConections = new System.Windows.Forms.GroupBox();
			this.MaxLengthUnD = new System.Windows.Forms.NumericUpDown();
			this.MaxLengthLbl = new System.Windows.Forms.Label();
			this.CreateConecionsChB = new System.Windows.Forms.CheckBox();
			this.OkBtn = new System.Windows.Forms.Button();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.PictureBoxGitHub = new System.Windows.Forms.PictureBox();
			this.toolTipGitHub = new System.Windows.Forms.ToolTip(this.components);
			this.GroupBoxStar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LifeTimeUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DensityUnD)).BeginInit();
			this.GroupBoxConections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxLengthUnD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGitHub)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBoxStar
			// 
			this.GroupBoxStar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBoxStar.Controls.Add(this.LifeTimeUnD);
			this.GroupBoxStar.Controls.Add(this.SizeUnD);
			this.GroupBoxStar.Controls.Add(this.SpeedUnD);
			this.GroupBoxStar.Controls.Add(this.LifeTimeLbl);
			this.GroupBoxStar.Controls.Add(this.SpeedLbl);
			this.GroupBoxStar.Controls.Add(this.SizeLbl);
			this.GroupBoxStar.Controls.Add(this.DensityUnD);
			this.GroupBoxStar.Controls.Add(this.DensityLbl);
			this.GroupBoxStar.Location = new System.Drawing.Point(12, 12);
			this.GroupBoxStar.Name = "GroupBoxStar";
			this.GroupBoxStar.Size = new System.Drawing.Size(220, 132);
			this.GroupBoxStar.TabIndex = 0;
			this.GroupBoxStar.TabStop = false;
			this.GroupBoxStar.Text = "Star";
			// 
			// LifeTimeUnD
			// 
			this.LifeTimeUnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LifeTimeUnD.Location = new System.Drawing.Point(119, 102);
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
			this.SizeUnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SizeUnD.Location = new System.Drawing.Point(119, 46);
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
			this.SpeedUnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SpeedUnD.Location = new System.Drawing.Point(119, 74);
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
			// LifeTimeLbl
			// 
			this.LifeTimeLbl.AutoSize = true;
			this.LifeTimeLbl.Location = new System.Drawing.Point(6, 104);
			this.LifeTimeLbl.Name = "LifeTimeLbl";
			this.LifeTimeLbl.Size = new System.Drawing.Size(46, 13);
			this.LifeTimeLbl.TabIndex = 6;
			this.LifeTimeLbl.Text = "Life time";
			// 
			// SpeedLbl
			// 
			this.SpeedLbl.AutoSize = true;
			this.SpeedLbl.Location = new System.Drawing.Point(6, 76);
			this.SpeedLbl.Name = "SpeedLbl";
			this.SpeedLbl.Size = new System.Drawing.Size(84, 13);
			this.SpeedLbl.TabIndex = 4;
			this.SpeedLbl.Text = "Twinkling speed";
			// 
			// SizeLbl
			// 
			this.SizeLbl.AutoSize = true;
			this.SizeLbl.Location = new System.Drawing.Point(6, 48);
			this.SizeLbl.Name = "SizeLbl";
			this.SizeLbl.Size = new System.Drawing.Size(27, 13);
			this.SizeLbl.TabIndex = 2;
			this.SizeLbl.Text = "Size";
			// 
			// DensityUnD
			// 
			this.DensityUnD.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.DensityUnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DensityUnD.Location = new System.Drawing.Point(119, 18);
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
			// DensityLbl
			// 
			this.DensityLbl.AutoSize = true;
			this.DensityLbl.Location = new System.Drawing.Point(6, 20);
			this.DensityLbl.Name = "DensityLbl";
			this.DensityLbl.Size = new System.Drawing.Size(42, 13);
			this.DensityLbl.TabIndex = 0;
			this.DensityLbl.Text = "Density";
			// 
			// GroupBoxConections
			// 
			this.GroupBoxConections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBoxConections.Controls.Add(this.MaxLengthUnD);
			this.GroupBoxConections.Controls.Add(this.MaxLengthLbl);
			this.GroupBoxConections.Controls.Add(this.CreateConecionsChB);
			this.GroupBoxConections.Location = new System.Drawing.Point(12, 150);
			this.GroupBoxConections.Name = "GroupBoxConections";
			this.GroupBoxConections.Size = new System.Drawing.Size(220, 78);
			this.GroupBoxConections.TabIndex = 1;
			this.GroupBoxConections.TabStop = false;
			this.GroupBoxConections.Text = "Conections";
			// 
			// MaxLengthUnD
			// 
			this.MaxLengthUnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MaxLengthUnD.Location = new System.Drawing.Point(119, 46);
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
			// MaxLengthLbl
			// 
			this.MaxLengthLbl.AutoSize = true;
			this.MaxLengthLbl.Location = new System.Drawing.Point(6, 48);
			this.MaxLengthLbl.Name = "MaxLengthLbl";
			this.MaxLengthLbl.Size = new System.Drawing.Size(59, 13);
			this.MaxLengthLbl.TabIndex = 1;
			this.MaxLengthLbl.Text = "Max length";
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
			this.OkBtn.Location = new System.Drawing.Point(155, 239);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(75, 23);
			this.OkBtn.TabIndex = 2;
			this.OkBtn.Text = "OK";
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
			// PictureBoxGitHub
			// 
			this.PictureBoxGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PictureBoxGitHub.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxGitHub.Image")));
			this.PictureBoxGitHub.InitialImage = null;
			this.PictureBoxGitHub.Location = new System.Drawing.Point(110, 239);
			this.PictureBoxGitHub.Name = "PictureBoxGitHub";
			this.PictureBoxGitHub.Size = new System.Drawing.Size(23, 23);
			this.PictureBoxGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxGitHub.TabIndex = 4;
			this.PictureBoxGitHub.TabStop = false;
			this.toolTipGitHub.SetToolTip(this.PictureBoxGitHub, "Source Code");
			this.PictureBoxGitHub.Click += new System.EventHandler(this.PictureBoxGitHub_Click);
			// 
			// toolTipGitHub
			// 
			this.toolTipGitHub.AutoPopDelay = 5000;
			this.toolTipGitHub.InitialDelay = 200;
			this.toolTipGitHub.ReshowDelay = 100;
			// 
			// Form2
			// 
			this.AcceptButton = this.OkBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 274);
			this.Controls.Add(this.PictureBoxGitHub);
			this.Controls.Add(this.ResetBtn);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.GroupBoxConections);
			this.Controls.Add(this.GroupBoxStar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StarScreen";
			this.GroupBoxStar.ResumeLayout(false);
			this.GroupBoxStar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LifeTimeUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpeedUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DensityUnD)).EndInit();
			this.GroupBoxConections.ResumeLayout(false);
			this.GroupBoxConections.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxLengthUnD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGitHub)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBoxStar;
		private System.Windows.Forms.GroupBox GroupBoxConections;
		private System.Windows.Forms.Label DensityLbl;
		private System.Windows.Forms.NumericUpDown DensityUnD;
		private System.Windows.Forms.NumericUpDown LifeTimeUnD;
		private System.Windows.Forms.NumericUpDown SizeUnD;
		private System.Windows.Forms.NumericUpDown SpeedUnD;
		private System.Windows.Forms.Label LifeTimeLbl;
		private System.Windows.Forms.Label SpeedLbl;
		private System.Windows.Forms.Label SizeLbl;
		private System.Windows.Forms.CheckBox CreateConecionsChB;
		private System.Windows.Forms.NumericUpDown MaxLengthUnD;
		private System.Windows.Forms.Label MaxLengthLbl;
		private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.Button ResetBtn;
		private System.Windows.Forms.PictureBox PictureBoxGitHub;
		private System.Windows.Forms.ToolTip toolTipGitHub;
	}
}