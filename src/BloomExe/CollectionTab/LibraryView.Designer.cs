﻿namespace Bloom.CollectionTab
{
	partial class LibraryView
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._topBarControl = new System.Windows.Forms.Panel();
			this._toolStrip = new System.Windows.Forms.ToolStrip();
			this._sendReceiveButton = new System.Windows.Forms.ToolStripButton();
			this._makeBloomPackButton = new System.Windows.Forms.ToolStripButton();
			this._L10NSharpExtender = new L10NSharp.UI.L10NSharpExtender(this.components);
			this.splitContainer1 = new Bloom.ToPalaso.BetterSplitContainer(this.components);
			this._topBarControl.SuspendLayout();
			this._toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._L10NSharpExtender)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			//
			// _topBarControl
			//
			this._topBarControl.Controls.Add(this._toolStrip);
			this._topBarControl.Location = new System.Drawing.Point(223, 224);
			this._topBarControl.Name = "_topBarControl";
			this._topBarControl.Size = new System.Drawing.Size(327, 70);
			this._topBarControl.TabIndex = 15;
			//
			// _toolStrip
			//
			this._toolStrip.BackColor = System.Drawing.Color.Transparent;
			this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._sendReceiveButton,
			this._makeBloomPackButton});
			this._toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this._L10NSharpExtender.SetLocalizableToolTip(this._toolStrip, null);
			this._L10NSharpExtender.SetLocalizationComment(this._toolStrip, null);
			this._L10NSharpExtender.SetLocalizationPriority(this._toolStrip, L10NSharp.LocalizationPriority.NotLocalizable);
			this._L10NSharpExtender.SetLocalizingId(this._toolStrip, "WorkspaceView._toolStrip");
			this._toolStrip.Location = new System.Drawing.Point(0, 0);
			this._toolStrip.Name = "_toolStrip";
			this._toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._toolStrip.Size = new System.Drawing.Size(327, 46);
			this._toolStrip.TabIndex = 31;
			this._toolStrip.Text = "_toolStrip";
			//
			// _sendReceiveButton
			//
			this._sendReceiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._sendReceiveButton.Image = global::Bloom.Properties.Resources.sendreceiveToolbarButton;
			this._sendReceiveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._sendReceiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._L10NSharpExtender.SetLocalizableToolTip(this._sendReceiveButton, null);
			this._L10NSharpExtender.SetLocalizationComment(this._sendReceiveButton, null);
			this._L10NSharpExtender.SetLocalizingId(this._sendReceiveButton, "CollectionTab.SendReceive");
			this._sendReceiveButton.Name = "_sendReceiveButton";
			this._sendReceiveButton.Size = new System.Drawing.Size(82, 43);
			this._sendReceiveButton.Text = "Send/Receive";
			this._sendReceiveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			//
			// _makeBloomPackButton
			//
			this._makeBloomPackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._makeBloomPackButton.Image = global::Bloom.Properties.Resources.PackageFlat;
			this._makeBloomPackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._makeBloomPackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._L10NSharpExtender.SetLocalizableToolTip(this._makeBloomPackButton, null);
			this._L10NSharpExtender.SetLocalizationComment(this._makeBloomPackButton, null);
			this._L10NSharpExtender.SetLocalizationPriority(this._makeBloomPackButton, L10NSharp.LocalizationPriority.Medium);
			this._L10NSharpExtender.SetLocalizingId(this._makeBloomPackButton, "CollectionTab._makeBloomPackButton");
			this._makeBloomPackButton.Name = "_makeBloomPackButton";
			this._makeBloomPackButton.Size = new System.Drawing.Size(106, 43);
			this._makeBloomPackButton.Text = "Make Bloom Pack";
			this._makeBloomPackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._makeBloomPackButton.Click += new System.EventHandler(this.OnMakeBloomPackButton_Click);
			//
			// _L10NSharpExtender
			//
			this._L10NSharpExtender.LocalizationManagerId = "Bloom";
			//
			// splitContainer1
			//
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._L10NSharpExtender.SetLocalizableToolTip(this.splitContainer1, null);
			this._L10NSharpExtender.SetLocalizationComment(this.splitContainer1, null);
			this._L10NSharpExtender.SetLocalizationPriority(this.splitContainer1, L10NSharp.LocalizationPriority.NotLocalizable);
			this._L10NSharpExtender.SetLocalizingId(this.splitContainer1, "LibraryView.splitContainer1");
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Size = new System.Drawing.Size(773, 518);
			this.splitContainer1.SplitterDistance = 333;
			this.splitContainer1.SplitterWidth = 10;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.TabStop = false;
			//
			// LibraryView
			//
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this._topBarControl);
			this.Controls.Add(this.splitContainer1);
			this._L10NSharpExtender.SetLocalizableToolTip(this, null);
			this._L10NSharpExtender.SetLocalizationComment(this, null);
			this._L10NSharpExtender.SetLocalizingId(this, "CollectionTab..LibraryView");
			this.Name = "LibraryView";
			this.Size = new System.Drawing.Size(773, 518);
			this.Load += new System.EventHandler(this.LibraryView_Load);
			this._topBarControl.ResumeLayout(false);
			this._topBarControl.PerformLayout();
			this._toolStrip.ResumeLayout(false);
			this._toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._L10NSharpExtender)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bloom.ToPalaso.BetterSplitContainer splitContainer1;
		public System.Windows.Forms.Panel _topBarControl;
		private L10NSharp.UI.L10NSharpExtender _L10NSharpExtender;
		private System.Windows.Forms.ToolStrip _toolStrip;
		private System.Windows.Forms.ToolStripButton _sendReceiveButton;
		private System.Windows.Forms.ToolStripButton _makeBloomPackButton;


	}
}
