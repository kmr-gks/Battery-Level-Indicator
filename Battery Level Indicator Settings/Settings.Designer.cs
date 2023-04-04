namespace Battery_Level_Indicator_Settings
{
	partial class Settings
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
			checkBoxAutostart = new CheckBox();
			buttonIndicatorStart = new Button();
			groupBoxPos = new GroupBox();
			numericPosY = new NumericUpDown();
			numericPosX = new NumericUpDown();
			radioButtonPosCustom = new RadioButton();
			radioButtonRightBottom = new RadioButton();
			radioButtonRightTop = new RadioButton();
			radioButtonLeftBottom = new RadioButton();
			radioButtonLeftTop = new RadioButton();
			buttonAboutStartup = new Button();
			groupBoxPos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericPosY).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericPosX).BeginInit();
			SuspendLayout();
			// 
			// checkBoxAutostart
			// 
			checkBoxAutostart.AutoSize = true;
			checkBoxAutostart.Location = new Point(12, 41);
			checkBoxAutostart.Name = "checkBoxAutostart";
			checkBoxAutostart.Size = new Size(162, 19);
			checkBoxAutostart.TabIndex = 0;
			checkBoxAutostart.Text = "Show indicator on startup";
			checkBoxAutostart.UseVisualStyleBackColor = true;
			checkBoxAutostart.CheckedChanged += checkBoxAutostart_CheckedChanged;
			// 
			// buttonIndicatorStart
			// 
			buttonIndicatorStart.Location = new Point(12, 12);
			buttonIndicatorStart.Name = "buttonIndicatorStart";
			buttonIndicatorStart.Size = new Size(162, 23);
			buttonIndicatorStart.TabIndex = 1;
			buttonIndicatorStart.Text = "Enable indicator now.";
			buttonIndicatorStart.UseVisualStyleBackColor = true;
			buttonIndicatorStart.Click += buttonIndicatorStart_Click;
			// 
			// groupBoxPos
			// 
			groupBoxPos.Controls.Add(numericPosY);
			groupBoxPos.Controls.Add(numericPosX);
			groupBoxPos.Controls.Add(radioButtonPosCustom);
			groupBoxPos.Controls.Add(radioButtonRightBottom);
			groupBoxPos.Controls.Add(radioButtonRightTop);
			groupBoxPos.Controls.Add(radioButtonLeftBottom);
			groupBoxPos.Controls.Add(radioButtonLeftTop);
			groupBoxPos.Location = new Point(12, 66);
			groupBoxPos.Name = "groupBoxPos";
			groupBoxPos.Size = new Size(273, 158);
			groupBoxPos.TabIndex = 4;
			groupBoxPos.TabStop = false;
			groupBoxPos.Text = "Indicator Position";
			// 
			// numericPosY
			// 
			numericPosY.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			numericPosY.Location = new Point(181, 122);
			numericPosY.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			numericPosY.Name = "numericPosY";
			numericPosY.Size = new Size(80, 23);
			numericPosY.TabIndex = 8;
			numericPosY.ValueChanged += numericPos_ValueChanged;
			// 
			// numericPosX
			// 
			numericPosX.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			numericPosX.Location = new Point(95, 122);
			numericPosX.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			numericPosX.Name = "numericPosX";
			numericPosX.Size = new Size(80, 23);
			numericPosX.TabIndex = 7;
			numericPosX.ValueChanged += numericPos_ValueChanged;
			// 
			// radioButtonPosCustom
			// 
			radioButtonPosCustom.AutoSize = true;
			radioButtonPosCustom.Location = new Point(6, 122);
			radioButtonPosCustom.Name = "radioButtonPosCustom";
			radioButtonPosCustom.Size = new Size(83, 19);
			radioButtonPosCustom.TabIndex = 4;
			radioButtonPosCustom.TabStop = true;
			radioButtonPosCustom.Text = "Other (X,Y)";
			radioButtonPosCustom.UseVisualStyleBackColor = true;
			radioButtonPosCustom.CheckedChanged += radioButtonPosition_CheckedChanged;
			// 
			// radioButtonRightBottom
			// 
			radioButtonRightBottom.AutoSize = true;
			radioButtonRightBottom.Location = new Point(6, 97);
			radioButtonRightBottom.Name = "radioButtonRightBottom";
			radioButtonRightBottom.Size = new Size(95, 19);
			radioButtonRightBottom.TabIndex = 3;
			radioButtonRightBottom.TabStop = true;
			radioButtonRightBottom.Text = "Right bottom";
			radioButtonRightBottom.UseVisualStyleBackColor = true;
			radioButtonRightBottom.CheckedChanged += radioButtonPosition_CheckedChanged;
			// 
			// radioButtonRightTop
			// 
			radioButtonRightTop.AutoSize = true;
			radioButtonRightTop.Location = new Point(6, 72);
			radioButtonRightTop.Name = "radioButtonRightTop";
			radioButtonRightTop.Size = new Size(74, 19);
			radioButtonRightTop.TabIndex = 2;
			radioButtonRightTop.TabStop = true;
			radioButtonRightTop.Text = "Right top";
			radioButtonRightTop.UseVisualStyleBackColor = true;
			radioButtonRightTop.CheckedChanged += radioButtonPosition_CheckedChanged;
			// 
			// radioButtonLeftBottom
			// 
			radioButtonLeftBottom.AutoSize = true;
			radioButtonLeftBottom.Location = new Point(6, 47);
			radioButtonLeftBottom.Name = "radioButtonLeftBottom";
			radioButtonLeftBottom.Size = new Size(87, 19);
			radioButtonLeftBottom.TabIndex = 1;
			radioButtonLeftBottom.TabStop = true;
			radioButtonLeftBottom.Text = "Left bottom";
			radioButtonLeftBottom.UseVisualStyleBackColor = true;
			radioButtonLeftBottom.CheckedChanged += radioButtonPosition_CheckedChanged;
			// 
			// radioButtonLeftTop
			// 
			radioButtonLeftTop.AutoSize = true;
			radioButtonLeftTop.Location = new Point(6, 22);
			radioButtonLeftTop.Name = "radioButtonLeftTop";
			radioButtonLeftTop.Size = new Size(66, 19);
			radioButtonLeftTop.TabIndex = 0;
			radioButtonLeftTop.TabStop = true;
			radioButtonLeftTop.Text = "Left top";
			radioButtonLeftTop.UseVisualStyleBackColor = true;
			radioButtonLeftTop.CheckedChanged += radioButtonPosition_CheckedChanged;
			// 
			// buttonAboutStartup
			// 
			buttonAboutStartup.Location = new Point(193, 37);
			buttonAboutStartup.Name = "buttonAboutStartup";
			buttonAboutStartup.Size = new Size(92, 23);
			buttonAboutStartup.TabIndex = 5;
			buttonAboutStartup.Text = "About startup";
			buttonAboutStartup.UseVisualStyleBackColor = true;
			buttonAboutStartup.Click += buttonAboutStartup_Click;
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(297, 231);
			Controls.Add(buttonAboutStartup);
			Controls.Add(groupBoxPos);
			Controls.Add(buttonIndicatorStart);
			Controls.Add(checkBoxAutostart);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Settings";
			Text = "Battery Level Indicator Settings";
			FormClosed += Settings_FormClosed;
			groupBoxPos.ResumeLayout(false);
			groupBoxPos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericPosY).EndInit();
			((System.ComponentModel.ISupportInitialize)numericPosX).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox checkBoxAutostart;
		private Button buttonIndicatorStart;
		private GroupBox groupBoxPos;
		private RadioButton radioButtonRightBottom;
		private RadioButton radioButtonRightTop;
		private RadioButton radioButtonLeftBottom;
		private RadioButton radioButtonLeftTop;
		private RadioButton radioButtonPosCustom;
		private NumericUpDown numericPosX;
		private NumericUpDown numericPosY;
		private Button buttonAboutStartup;
	}
}