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
			// Settings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(378, 226);
			Controls.Add(buttonIndicatorStart);
			Controls.Add(checkBoxAutostart);
			Name = "Settings";
			Text = "Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox checkBoxAutostart;
		private Button buttonIndicatorStart;
	}
}