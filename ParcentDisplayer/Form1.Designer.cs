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
			SuspendLayout();
			// 
			// textBoxParcent
			// 
			textBoxParcent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxParcent.Location = new Point(0, 0);
			textBoxParcent.Margin = new Padding(0);
			textBoxParcent.Name = "textBoxParcent";
			textBoxParcent.ReadOnly = true;
			textBoxParcent.Size = new Size(293, 23);
			textBoxParcent.TabIndex = 0;
			textBoxParcent.Text = "%%%";
			textBoxParcent.TextAlign = HorizontalAlignment.Center;
			textBoxParcent.TextChanged += textBoxParcent_TextChanged;
			// 
			// ParcentForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(353, 214);
			ControlBox = false;
			Controls.Add(textBoxParcent);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "ParcentForm";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxParcent;
	}
}