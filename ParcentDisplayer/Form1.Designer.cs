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
			components = new System.ComponentModel.Container();
			labelParcent = new Label();
			contextMenuMain = new ContextMenuStrip(components);
			SuspendLayout();
			// 
			// labelParcent
			// 
			labelParcent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			labelParcent.AutoSize = true;
			labelParcent.ContextMenuStrip = contextMenuMain;
			labelParcent.Location = new Point(0, 0);
			labelParcent.Margin = new Padding(0);
			labelParcent.MaximumSize = new Size(40, 20);
			labelParcent.MinimumSize = new Size(40, 20);
			labelParcent.Name = "labelParcent";
			labelParcent.Size = new Size(40, 20);
			labelParcent.TabIndex = 0;
			labelParcent.Text = "label1";
			labelParcent.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// contextMenuMain
			// 
			contextMenuMain.Name = "contextMenuStrip2";
			contextMenuMain.Size = new Size(61, 4);
			// 
			// ParcentForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.White;
			ClientSize = new Size(40, 20);
			ContextMenuStrip = contextMenuMain;
			ControlBox = false;
			Controls.Add(labelParcent);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			MaximumSize = new Size(40, 20);
			MinimizeBox = false;
			MinimumSize = new Size(40, 20);
			Name = "ParcentForm";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelParcent;
		private ContextMenuStrip contextMenuMain;
	}
}