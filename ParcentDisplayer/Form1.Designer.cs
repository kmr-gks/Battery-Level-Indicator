namespace ParcentDisplayer
{
	partial class ParcentForm
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
			textBoxParcent = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBoxParcent
			// 
			textBoxParcent.Location = new Point(28, 12);
			textBoxParcent.Name = "textBoxParcent";
			textBoxParcent.ReadOnly = true;
			textBoxParcent.Size = new Size(100, 23);
			textBoxParcent.TabIndex = 0;
			textBoxParcent.Text = "%%%";
			// 
			// button1
			// 
			button1.Location = new Point(161, 94);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(359, 211);
			Controls.Add(button1);
			Controls.Add(textBoxParcent);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxParcent;
		private Button button1;
	}
}