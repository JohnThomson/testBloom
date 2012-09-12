﻿namespace Bloom.Publish
{
	partial class PublishView
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
			this._loadTimer = new System.Windows.Forms.Timer(this.components);
			this._makePdfBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this._workingIndicator = new System.Windows.Forms.Panel();
			this._topBarPanel = new System.Windows.Forms.Panel();
			this._saveButton = new System.Windows.Forms.Button();
			this._printButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._openinBrowserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._menusToolStrip = new System.Windows.Forms.ToolStrip();
			this._layoutChoices = new System.Windows.Forms.ToolStripDropDownButton();
			this._bodyRadio = new System.Windows.Forms.RadioButton();
			this._coverRadio = new System.Windows.Forms.RadioButton();
			this._noBookletRadio = new System.Windows.Forms.RadioButton();
			this.localizationExtender1 = new Localization.UI.LocalizationExtender(this.components);
			this._adobeReaderControl = new Bloom.Publish.AdobeReaderControl();
			this._workingIndicator.SuspendLayout();
			this._topBarPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this._menusToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.localizationExtender1)).BeginInit();
			this.SuspendLayout();
			//
			// _makePdfBackgroundWorker
			//
			this._makePdfBackgroundWorker.WorkerSupportsCancellation = true;
			this._makePdfBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this._makePdfBackgroundWorker_DoWork);
			//
			// _workingIndicator
			//
			this._workingIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this._workingIndicator.BackColor = System.Drawing.Color.White;
			this._workingIndicator.Controls.Add(this._topBarPanel);
			this._workingIndicator.Location = new System.Drawing.Point(103, 24);
			this._workingIndicator.Name = "_workingIndicator";
			this._workingIndicator.Size = new System.Drawing.Size(714, 516);
			this._workingIndicator.TabIndex = 8;
			//
			// _topBarPanel
			//
			this._topBarPanel.Controls.Add(this._saveButton);
			this._topBarPanel.Controls.Add(this._printButton);
			this._topBarPanel.Location = new System.Drawing.Point(296, 320);
			this._topBarPanel.Name = "_topBarPanel";
			this._topBarPanel.Size = new System.Drawing.Size(327, 70);
			this._topBarPanel.TabIndex = 14;
			//
			// _saveButton
			//
			this._saveButton.AutoSize = true;
			this._saveButton.BackColor = System.Drawing.Color.Transparent;
			this._saveButton.FlatAppearance.BorderSize = 0;
			this._saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._saveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._saveButton.ForeColor = System.Drawing.Color.Black;
			this._saveButton.Image = global::Bloom.Properties.Resources.Usb;
			this.localizationExtender1.SetLocalizableToolTip(this._saveButton, null);
			this.localizationExtender1.SetLocalizationComment(this._saveButton, null);
			this.localizationExtender1.SetLocalizingId(this._saveButton, "PublishView.SaveButton");
			this._saveButton.Location = new System.Drawing.Point(108, 0);
			this._saveButton.Name = "_saveButton";
			this._saveButton.Size = new System.Drawing.Size(185, 71);
			this._saveButton.TabIndex = 15;
			this._saveButton.Text = "&Save PDF...";
			this._saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._saveButton.UseVisualStyleBackColor = false;
			this._saveButton.Click += new System.EventHandler(this.OnSave_Click);
			//
			// _printButton
			//
			this._printButton.AutoSize = true;
			this._printButton.BackColor = System.Drawing.Color.Transparent;
			this._printButton.FlatAppearance.BorderSize = 0;
			this._printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._printButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._printButton.ForeColor = System.Drawing.Color.Black;
			this._printButton.Image = global::Bloom.Properties.Resources.print;
			this.localizationExtender1.SetLocalizableToolTip(this._printButton, null);
			this.localizationExtender1.SetLocalizationComment(this._printButton, null);
			this.localizationExtender1.SetLocalizingId(this._printButton, "PublishView.PrintButton");
			this._printButton.Location = new System.Drawing.Point(0, 0);
			this._printButton.Name = "_printButton";
			this._printButton.Size = new System.Drawing.Size(105, 64);
			this._printButton.TabIndex = 14;
			this._printButton.Text = "&Print...";
			this._printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._printButton.UseVisualStyleBackColor = false;
			this._printButton.Click += new System.EventHandler(this.OnPrint_Click);
			//
			// tableLayoutPanel1
			//
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
			this.tableLayoutPanel1.Controls.Add(this._menusToolStrip, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._bodyRadio, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this._coverRadio, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._noBookletRadio, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 540);
			this.tableLayoutPanel1.TabIndex = 10;
			//
			// contextMenuStrip1
			//
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._openinBrowserMenuItem});
			this.localizationExtender1.SetLocalizableToolTip(this.contextMenuStrip1, null);
			this.localizationExtender1.SetLocalizationComment(this.contextMenuStrip1, null);
			this.localizationExtender1.SetLocalizingId(this.contextMenuStrip1, "contextMenuStrip1.contextMenuStrip1");
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(335, 26);
			//
			// _openinBrowserMenuItem
			//
			this.localizationExtender1.SetLocalizableToolTip(this._openinBrowserMenuItem, null);
			this.localizationExtender1.SetLocalizationComment(this._openinBrowserMenuItem, null);
			this.localizationExtender1.SetLocalizationPriority(this._openinBrowserMenuItem, Localization.LocalizationPriority.Low);
			this.localizationExtender1.SetLocalizingId(this._openinBrowserMenuItem, ".openHtmlInBrowserToolStripMenuItem");
			this._openinBrowserMenuItem.Name = "_openinBrowserMenuItem";
			this._openinBrowserMenuItem.Size = new System.Drawing.Size(334, 22);
			this._openinBrowserMenuItem.Text = "Open the Html used to make this PDF, in Browser";
			this._openinBrowserMenuItem.Click += new System.EventHandler(this._openinBrowserMenuItem_Click);
			//
			// _menusToolStrip
			//
			this._menusToolStrip.AutoSize = false;
			this._menusToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._menusToolStrip.CanOverflow = false;
			this._menusToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._menusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this._menusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._layoutChoices});
			this._menusToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.localizationExtender1.SetLocalizableToolTip(this._menusToolStrip, null);
			this.localizationExtender1.SetLocalizationComment(this._menusToolStrip, null);
			this.localizationExtender1.SetLocalizingId(this._menusToolStrip, "EditingView._menusToolStrip");
			this._menusToolStrip.Location = new System.Drawing.Point(0, 340);
			this._menusToolStrip.Name = "_menusToolStrip";
			this._menusToolStrip.Size = new System.Drawing.Size(100, 20);
			this._menusToolStrip.TabIndex = 6;
			this._menusToolStrip.Text = "toolStrip1";
			//
			// _layoutChoices
			//
			this._layoutChoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._layoutChoices.ForeColor = System.Drawing.Color.White;
			this._layoutChoices.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.localizationExtender1.SetLocalizableToolTip(this._layoutChoices, null);
			this.localizationExtender1.SetLocalizationComment(this._layoutChoices, null);
			this.localizationExtender1.SetLocalizingId(this._layoutChoices, "._layoutChoices");
			this._layoutChoices.Name = "_layoutChoices";
			this._layoutChoices.Size = new System.Drawing.Size(85, 19);
			this._layoutChoices.Text = "Page Layout";
			this._layoutChoices.ToolTipText = "Choose a page size and orientation";
			//
			// _bodyRadio
			//
			this._bodyRadio.Image = global::Bloom.Properties.Resources.insideBookletPages;
			this.localizationExtender1.SetLocalizableToolTip(this._bodyRadio, null);
			this.localizationExtender1.SetLocalizationComment(this._bodyRadio, null);
			this.localizationExtender1.SetLocalizingId(this._bodyRadio, "PublishView.BodyOnlyRadio");
			this._bodyRadio.Location = new System.Drawing.Point(3, 233);
			this._bodyRadio.Name = "_bodyRadio";
			this._bodyRadio.Size = new System.Drawing.Size(94, 104);
			this._bodyRadio.TabIndex = 5;
			this._bodyRadio.TabStop = true;
			this._bodyRadio.Text = "Booklet Inside Pages";
			this._bodyRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._bodyRadio.UseVisualStyleBackColor = true;
			this._bodyRadio.CheckedChanged += new System.EventHandler(this.OnBookletRadioChanged);
			//
			// _coverRadio
			//
			this._coverRadio.Image = global::Bloom.Properties.Resources.coverOnly;
			this.localizationExtender1.SetLocalizableToolTip(this._coverRadio, null);
			this.localizationExtender1.SetLocalizationComment(this._coverRadio, null);
			this.localizationExtender1.SetLocalizingId(this._coverRadio, "PublishView.CoverOnlyRadio");
			this._coverRadio.Location = new System.Drawing.Point(3, 116);
			this._coverRadio.Name = "_coverRadio";
			this._coverRadio.Size = new System.Drawing.Size(94, 111);
			this._coverRadio.TabIndex = 4;
			this._coverRadio.TabStop = true;
			this._coverRadio.Text = "Booklet Cover Page";
			this._coverRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._coverRadio.UseVisualStyleBackColor = true;
			this._coverRadio.CheckedChanged += new System.EventHandler(this.OnBookletRadioChanged);
			//
			// _noBookletRadio
			//
			this._noBookletRadio.Image = global::Bloom.Properties.Resources.simplePages;
			this.localizationExtender1.SetLocalizableToolTip(this._noBookletRadio, null);
			this.localizationExtender1.SetLocalizationComment(this._noBookletRadio, "Instead of making a booklet, just make normal pages");
			this.localizationExtender1.SetLocalizingId(this._noBookletRadio, "PublishView.OnPagePerPaperRadio");
			this._noBookletRadio.Location = new System.Drawing.Point(3, 3);
			this._noBookletRadio.Name = "_noBookletRadio";
			this._noBookletRadio.Size = new System.Drawing.Size(94, 107);
			this._noBookletRadio.TabIndex = 3;
			this._noBookletRadio.TabStop = true;
			this._noBookletRadio.Text = "One page per piece of paper";
			this._noBookletRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._noBookletRadio.UseVisualStyleBackColor = true;
			this._noBookletRadio.CheckedChanged += new System.EventHandler(this.OnBookletRadioChanged);
			//
			// localizationExtender1
			//
			this.localizationExtender1.LocalizationManagerId = "Bloom";
			//
			// _adobeReaderControl
			//
			this._adobeReaderControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this._adobeReaderControl.BackColor = System.Drawing.Color.White;
			this.localizationExtender1.SetLocalizableToolTip(this._adobeReaderControl, null);
			this.localizationExtender1.SetLocalizationComment(this._adobeReaderControl, null);
			this.localizationExtender1.SetLocalizingId(this._adobeReaderControl, "adobeReaderControl1.AdobeReaderControl");
			this._adobeReaderControl.Location = new System.Drawing.Point(103, 3);
			this._adobeReaderControl.Name = "_adobeReaderControl";
			this._adobeReaderControl.Size = new System.Drawing.Size(727, 537);
			this._adobeReaderControl.TabIndex = 16;
			//
			// PublishView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._workingIndicator);
			this.Controls.Add(this._adobeReaderControl);
			this.localizationExtender1.SetLocalizableToolTip(this, null);
			this.localizationExtender1.SetLocalizationComment(this, null);
			this.localizationExtender1.SetLocalizingId(this, "PublishView.PublishView");
			this.Name = "PublishView";
			this.Size = new System.Drawing.Size(833, 540);
			this._workingIndicator.ResumeLayout(false);
			this._topBarPanel.ResumeLayout(false);
			this._topBarPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this._menusToolStrip.ResumeLayout(false);
			this._menusToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.localizationExtender1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer _loadTimer;

		private System.ComponentModel.BackgroundWorker _makePdfBackgroundWorker;
		private System.Windows.Forms.Panel _workingIndicator;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton _bodyRadio;
		private System.Windows.Forms.RadioButton _coverRadio;
		private System.Windows.Forms.RadioButton _noBookletRadio;
		private System.Windows.Forms.Panel _topBarPanel;
		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.Button _printButton;
		private Localization.UI.LocalizationExtender localizationExtender1;
		private AdobeReaderControl _adobeReaderControl;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem _openinBrowserMenuItem;
		private System.Windows.Forms.ToolStrip _menusToolStrip;
		private System.Windows.Forms.ToolStripDropDownButton _layoutChoices;
	}
}