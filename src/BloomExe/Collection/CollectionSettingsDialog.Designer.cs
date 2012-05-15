﻿namespace Bloom.Collection
{
	partial class CollectionSettingsDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionSettingsDialog));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this._aboutLanguageSettingsButton = new System.Windows.Forms.Button();
			this._removeLanguage3Link = new System.Windows.Forms.LinkLabel();
			this._changeLanguage3Link = new System.Windows.Forms.LinkLabel();
			this._changeLanguage2Link = new System.Windows.Forms.LinkLabel();
			this._changeLanguage1Link = new System.Windows.Forms.LinkLabel();
			this._nationalLanguage2Label = new System.Windows.Forms.Label();
			this._language3Label = new System.Windows.Forms.Label();
			this._nationalLanguage1Label = new System.Windows.Forms.Label();
			this._language2Label = new System.Windows.Forms.Label();
			this._vernacularLanguageName = new System.Windows.Forms.Label();
			this._language1Label = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this._aboutBookMakingSettingsButton = new System.Windows.Forms.Button();
			this._xmatterPackLabel = new System.Windows.Forms.Label();
			this._xmatterPackCombo = new System.Windows.Forms.ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this._aboutProjectInformationSetingsButton = new System.Windows.Forms.Button();
			this._districtText = new System.Windows.Forms.TextBox();
			this._provinceText = new System.Windows.Forms.TextBox();
			this._countryText = new System.Windows.Forms.TextBox();
			this._countryLabel = new System.Windows.Forms.Label();
			this._districtLabel = new System.Windows.Forms.Label();
			this._provinceLabel = new System.Windows.Forms.Label();
			this._okButton = new System.Windows.Forms.Button();
			this._restartReminder = new System.Windows.Forms.Label();
			this.settingsProtectionLauncherButton1 = new Palaso.UI.WindowsForms.SettingProtection.SettingsProtectionLauncherButton();
			this.localizationExtender1 = new Localization.UI.LocalizationExtender(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.localizationExtender1)).BeginInit();
			this.SuspendLayout();
			//
			// tabControl1
			//
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(1, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(619, 344);
			this.tabControl1.TabIndex = 0;
			//
			// tabPage1
			//
			this.tabPage1.Controls.Add(this._aboutLanguageSettingsButton);
			this.tabPage1.Controls.Add(this._removeLanguage3Link);
			this.tabPage1.Controls.Add(this._changeLanguage3Link);
			this.tabPage1.Controls.Add(this._changeLanguage2Link);
			this.tabPage1.Controls.Add(this._changeLanguage1Link);
			this.tabPage1.Controls.Add(this._nationalLanguage2Label);
			this.tabPage1.Controls.Add(this._language3Label);
			this.tabPage1.Controls.Add(this._nationalLanguage1Label);
			this.tabPage1.Controls.Add(this._language2Label);
			this.tabPage1.Controls.Add(this._vernacularLanguageName);
			this.tabPage1.Controls.Add(this._language1Label);
			this.localizationExtender1.SetLocalizableToolTip(this.tabPage1, null);
			this.localizationExtender1.SetLocalizationComment(this.tabPage1, null);
			this.localizationExtender1.SetLocalizingId(this.tabPage1, "CollectionSettingsDialog.tabPage1");
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(611, 314);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Languages";
			this.tabPage1.UseVisualStyleBackColor = true;
			//
			// _aboutLanguageSettingsButton
			//
			this._aboutLanguageSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._aboutLanguageSettingsButton.FlatAppearance.BorderSize = 0;
			this._aboutLanguageSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._aboutLanguageSettingsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._aboutLanguageSettingsButton.Image = global::Bloom.Properties.Resources.help24x24;
			this.localizationExtender1.SetLocalizableToolTip(this._aboutLanguageSettingsButton, null);
			this.localizationExtender1.SetLocalizationComment(this._aboutLanguageSettingsButton, null);
			this.localizationExtender1.SetLocalizationPriority(this._aboutLanguageSettingsButton, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._aboutLanguageSettingsButton, "CollectionSettingsDialog._aboutLanguageSettingsButton");
			this._aboutLanguageSettingsButton.Location = new System.Drawing.Point(478, 24);
			this._aboutLanguageSettingsButton.Name = "_aboutLanguageSettingsButton";
			this._aboutLanguageSettingsButton.Size = new System.Drawing.Size(113, 73);
			this._aboutLanguageSettingsButton.TabIndex = 19;
			this._aboutLanguageSettingsButton.Text = "About These Settings";
			this._aboutLanguageSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._aboutLanguageSettingsButton.UseVisualStyleBackColor = true;
			this._aboutLanguageSettingsButton.Click += new System.EventHandler(this.OnAboutLanguageSettings);
			//
			// _removeLanguage3Link
			//
			this._removeLanguage3Link.AutoSize = true;
			this.localizationExtender1.SetLocalizableToolTip(this._removeLanguage3Link, null);
			this.localizationExtender1.SetLocalizationComment(this._removeLanguage3Link, null);
			this.localizationExtender1.SetLocalizationPriority(this._removeLanguage3Link, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._removeLanguage3Link, "CollectionSettingsDialog._removeLanguageLink");
			this._removeLanguage3Link.Location = new System.Drawing.Point(159, 243);
			this._removeLanguage3Link.Name = "_removeLanguage3Link";
			this._removeLanguage3Link.Size = new System.Drawing.Size(58, 19);
			this._removeLanguage3Link.TabIndex = 18;
			this._removeLanguage3Link.TabStop = true;
			this._removeLanguage3Link.Text = "Remove";
			this._removeLanguage3Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._removeSecondNationalLanguageButton_LinkClicked);
			//
			// _changeLanguage3Link
			//
			this._changeLanguage3Link.AutoSize = true;
			this.localizationExtender1.SetLocalizableToolTip(this._changeLanguage3Link, null);
			this.localizationExtender1.SetLocalizationComment(this._changeLanguage3Link, null);
			this.localizationExtender1.SetLocalizationPriority(this._changeLanguage3Link, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._changeLanguage3Link, "CollectionSettingsDialog.ChangeLink");
			this._changeLanguage3Link.Location = new System.Drawing.Point(27, 243);
			this._changeLanguage3Link.Name = "_changeLanguage3Link";
			this._changeLanguage3Link.Size = new System.Drawing.Size(65, 19);
			this._changeLanguage3Link.TabIndex = 17;
			this._changeLanguage3Link.TabStop = true;
			this._changeLanguage3Link.Text = "Change...";
			this._changeLanguage3Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._national2ChangeLink_LinkClicked);
			//
			// _changeLanguage2Link
			//
			this._changeLanguage2Link.AutoSize = true;
			this.localizationExtender1.SetLocalizableToolTip(this._changeLanguage2Link, null);
			this.localizationExtender1.SetLocalizationComment(this._changeLanguage2Link, null);
			this.localizationExtender1.SetLocalizationPriority(this._changeLanguage2Link, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._changeLanguage2Link, "CollectionSettingsDialog.ChangeLink");
			this._changeLanguage2Link.Location = new System.Drawing.Point(27, 158);
			this._changeLanguage2Link.Name = "_changeLanguage2Link";
			this._changeLanguage2Link.Size = new System.Drawing.Size(65, 19);
			this._changeLanguage2Link.TabIndex = 16;
			this._changeLanguage2Link.TabStop = true;
			this._changeLanguage2Link.Text = "Change...";
			this._changeLanguage2Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._national1ChangeLink_LinkClicked);
			//
			// _changeLanguage1Link
			//
			this._changeLanguage1Link.AutoSize = true;
			this.localizationExtender1.SetLocalizableToolTip(this._changeLanguage1Link, null);
			this.localizationExtender1.SetLocalizationComment(this._changeLanguage1Link, null);
			this.localizationExtender1.SetLocalizationPriority(this._changeLanguage1Link, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._changeLanguage1Link, "CollectionSettingsDialog.ChangeLink");
			this._changeLanguage1Link.Location = new System.Drawing.Point(27, 69);
			this._changeLanguage1Link.Name = "_changeLanguage1Link";
			this._changeLanguage1Link.Size = new System.Drawing.Size(65, 19);
			this._changeLanguage1Link.TabIndex = 15;
			this._changeLanguage1Link.TabStop = true;
			this._changeLanguage1Link.Text = "Change...";
			this._changeLanguage1Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._vernacularChangeLink_LinkClicked);
			//
			// _nationalLanguage2Label
			//
			this._nationalLanguage2Label.AutoSize = true;
			this._nationalLanguage2Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._nationalLanguage2Label, null);
			this.localizationExtender1.SetLocalizationComment(this._nationalLanguage2Label, null);
			this.localizationExtender1.SetLocalizationPriority(this._nationalLanguage2Label, Localization.LocalizationPriority.NotLocalizable);
			this.localizationExtender1.SetLocalizingId(this._nationalLanguage2Label, "CollectionSettingsDialog._nationalLanguage2Label");
			this._nationalLanguage2Label.Location = new System.Drawing.Point(26, 218);
			this._nationalLanguage2Label.Name = "_nationalLanguage2Label";
			this._nationalLanguage2Label.Size = new System.Drawing.Size(49, 19);
			this._nationalLanguage2Label.TabIndex = 14;
			this._nationalLanguage2Label.Text = "foobar";
			//
			// _language3Label
			//
			this._language3Label.AutoSize = true;
			this._language3Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._language3Label, null);
			this.localizationExtender1.SetLocalizationComment(this._language3Label, null);
			this.localizationExtender1.SetLocalizationPriority(this._language3Label, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._language3Label, "CollectionSettingsDialog._language3Label");
			this._language3Label.Location = new System.Drawing.Point(26, 198);
			this._language3Label.Name = "_language3Label";
			this._language3Label.Size = new System.Drawing.Size(316, 19);
			this._language3Label.TabIndex = 13;
			this._language3Label.Text = "Language 3 (e.g. Regional Language)   (Optional)";
			//
			// _nationalLanguage1Label
			//
			this._nationalLanguage1Label.AutoSize = true;
			this._nationalLanguage1Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._nationalLanguage1Label, null);
			this.localizationExtender1.SetLocalizationComment(this._nationalLanguage1Label, null);
			this.localizationExtender1.SetLocalizationPriority(this._nationalLanguage1Label, Localization.LocalizationPriority.NotLocalizable);
			this.localizationExtender1.SetLocalizingId(this._nationalLanguage1Label, "CollectionSettingsDialog._nationalLanguage1Label");
			this._nationalLanguage1Label.Location = new System.Drawing.Point(26, 133);
			this._nationalLanguage1Label.Name = "_nationalLanguage1Label";
			this._nationalLanguage1Label.Size = new System.Drawing.Size(49, 19);
			this._nationalLanguage1Label.TabIndex = 11;
			this._nationalLanguage1Label.Text = "foobar";
			//
			// _language2Label
			//
			this._language2Label.AutoSize = true;
			this._language2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._language2Label, null);
			this.localizationExtender1.SetLocalizationComment(this._language2Label, null);
			this.localizationExtender1.SetLocalizationPriority(this._language2Label, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._language2Label, "CollectionSettingsDialog._language2Label");
			this._language2Label.Location = new System.Drawing.Point(26, 113);
			this._language2Label.Name = "_language2Label";
			this._language2Label.Size = new System.Drawing.Size(238, 19);
			this._language2Label.TabIndex = 10;
			this._language2Label.Text = "Language 2 (e.g. National Language)";
			this._language2Label.Click += new System.EventHandler(this.label4_Click);
			//
			// _vernacularLanguageName
			//
			this._vernacularLanguageName.AutoSize = true;
			this._vernacularLanguageName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._vernacularLanguageName, null);
			this.localizationExtender1.SetLocalizationComment(this._vernacularLanguageName, null);
			this.localizationExtender1.SetLocalizationPriority(this._vernacularLanguageName, Localization.LocalizationPriority.NotLocalizable);
			this.localizationExtender1.SetLocalizingId(this._vernacularLanguageName, "CollectionSettingsDialog._vernacularLanguageName");
			this._vernacularLanguageName.Location = new System.Drawing.Point(26, 44);
			this._vernacularLanguageName.Name = "_vernacularLanguageName";
			this._vernacularLanguageName.Size = new System.Drawing.Size(49, 19);
			this._vernacularLanguageName.TabIndex = 8;
			this._vernacularLanguageName.Text = "foobar";
			//
			// _language1Label
			//
			this._language1Label.AutoSize = true;
			this._language1Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._language1Label, null);
			this.localizationExtender1.SetLocalizationComment(this._language1Label, null);
			this.localizationExtender1.SetLocalizationPriority(this._language1Label, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._language1Label, "CollectionSettingsDialog._language1Label");
			this._language1Label.Location = new System.Drawing.Point(26, 24);
			this._language1Label.Name = "_language1Label";
			this._language1Label.Size = new System.Drawing.Size(140, 19);
			this._language1Label.TabIndex = 7;
			this._language1Label.Text = "Vernacular Language";
			//
			// tabPage2
			//
			this.tabPage2.Controls.Add(this._aboutBookMakingSettingsButton);
			this.tabPage2.Controls.Add(this._xmatterPackLabel);
			this.tabPage2.Controls.Add(this._xmatterPackCombo);
			this.localizationExtender1.SetLocalizableToolTip(this.tabPage2, null);
			this.localizationExtender1.SetLocalizationComment(this.tabPage2, null);
			this.localizationExtender1.SetLocalizingId(this.tabPage2, "CollectionSettingsDialog.tabPage2");
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(611, 314);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Book Making";
			this.tabPage2.UseVisualStyleBackColor = true;
			//
			// _aboutBookMakingSettingsButton
			//
			this._aboutBookMakingSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._aboutBookMakingSettingsButton.FlatAppearance.BorderSize = 0;
			this._aboutBookMakingSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._aboutBookMakingSettingsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._aboutBookMakingSettingsButton.Image = global::Bloom.Properties.Resources.help24x24;
			this.localizationExtender1.SetLocalizableToolTip(this._aboutBookMakingSettingsButton, null);
			this.localizationExtender1.SetLocalizationComment(this._aboutBookMakingSettingsButton, null);
			this.localizationExtender1.SetLocalizationPriority(this._aboutBookMakingSettingsButton, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._aboutBookMakingSettingsButton, "CollectionSettingsDialog._aboutBookMakingSettingsButton");
			this._aboutBookMakingSettingsButton.Location = new System.Drawing.Point(468, 30);
			this._aboutBookMakingSettingsButton.Name = "_aboutBookMakingSettingsButton";
			this._aboutBookMakingSettingsButton.Size = new System.Drawing.Size(113, 73);
			this._aboutBookMakingSettingsButton.TabIndex = 20;
			this._aboutBookMakingSettingsButton.Text = "About These Settings";
			this._aboutBookMakingSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._aboutBookMakingSettingsButton.UseVisualStyleBackColor = true;
			this._aboutBookMakingSettingsButton.Click += new System.EventHandler(this.OnAboutBookMakingSettings);
			//
			// _xmatterPackLabel
			//
			this._xmatterPackLabel.AutoSize = true;
			this._xmatterPackLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._xmatterPackLabel, null);
			this.localizationExtender1.SetLocalizationComment(this._xmatterPackLabel, null);
			this.localizationExtender1.SetLocalizationPriority(this._xmatterPackLabel, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._xmatterPackLabel, "CollectionSettingsDialog.label1");
			this._xmatterPackLabel.Location = new System.Drawing.Point(25, 32);
			this._xmatterPackLabel.Name = "_xmatterPackLabel";
			this._xmatterPackLabel.Size = new System.Drawing.Size(156, 19);
			this._xmatterPackLabel.TabIndex = 1;
			this._xmatterPackLabel.Text = "Front/Back Matter Pack";
			//
			// _xmatterPackCombo
			//
			this._xmatterPackCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._xmatterPackCombo.FormattingEnabled = true;
			this.localizationExtender1.SetLocalizableToolTip(this._xmatterPackCombo, null);
			this.localizationExtender1.SetLocalizationComment(this._xmatterPackCombo, null);
			this.localizationExtender1.SetLocalizingId(this._xmatterPackCombo, "CollectionSettingsDialog._xmatterPackCombo");
			this._xmatterPackCombo.Location = new System.Drawing.Point(29, 54);
			this._xmatterPackCombo.Name = "_xmatterPackCombo";
			this._xmatterPackCombo.Size = new System.Drawing.Size(146, 25);
			this._xmatterPackCombo.TabIndex = 0;
			//
			// tabPage3
			//
			this.tabPage3.Controls.Add(this._aboutProjectInformationSetingsButton);
			this.tabPage3.Controls.Add(this._districtText);
			this.tabPage3.Controls.Add(this._provinceText);
			this.tabPage3.Controls.Add(this._countryText);
			this.tabPage3.Controls.Add(this._countryLabel);
			this.tabPage3.Controls.Add(this._districtLabel);
			this.tabPage3.Controls.Add(this._provinceLabel);
			this.localizationExtender1.SetLocalizableToolTip(this.tabPage3, null);
			this.localizationExtender1.SetLocalizationComment(this.tabPage3, null);
			this.localizationExtender1.SetLocalizingId(this.tabPage3, "CollectionSettingsDialog.tabPage3");
			this.tabPage3.Location = new System.Drawing.Point(4, 26);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(611, 314);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Project Information";
			this.tabPage3.UseVisualStyleBackColor = true;
			//
			// _aboutProjectInformationSetingsButton
			//
			this._aboutProjectInformationSetingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._aboutProjectInformationSetingsButton.FlatAppearance.BorderSize = 0;
			this._aboutProjectInformationSetingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._aboutProjectInformationSetingsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._aboutProjectInformationSetingsButton.Image = global::Bloom.Properties.Resources.help24x24;
			this.localizationExtender1.SetLocalizableToolTip(this._aboutProjectInformationSetingsButton, null);
			this.localizationExtender1.SetLocalizationComment(this._aboutProjectInformationSetingsButton, null);
			this.localizationExtender1.SetLocalizationPriority(this._aboutProjectInformationSetingsButton, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._aboutProjectInformationSetingsButton, "CollectionSettingsDialog._aboutProjectInformationSetingsButton");
			this._aboutProjectInformationSetingsButton.Location = new System.Drawing.Point(479, 21);
			this._aboutProjectInformationSetingsButton.Name = "_aboutProjectInformationSetingsButton";
			this._aboutProjectInformationSetingsButton.Size = new System.Drawing.Size(113, 88);
			this._aboutProjectInformationSetingsButton.TabIndex = 20;
			this._aboutProjectInformationSetingsButton.Text = "About These Settings";
			this._aboutProjectInformationSetingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._aboutProjectInformationSetingsButton.UseVisualStyleBackColor = true;
			this._aboutProjectInformationSetingsButton.Click += new System.EventHandler(this.OnAboutProjectInformationSetingsButton_Click);
			//
			// _districtText
			//
			this._districtText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._districtText, null);
			this.localizationExtender1.SetLocalizationComment(this._districtText, null);
			this.localizationExtender1.SetLocalizingId(this._districtText, "CollectionSettingsDialog._districtText");
			this._districtText.Location = new System.Drawing.Point(32, 177);
			this._districtText.Name = "_districtText";
			this._districtText.Size = new System.Drawing.Size(214, 25);
			this._districtText.TabIndex = 5;
			//
			// _provinceText
			//
			this._provinceText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._provinceText, null);
			this.localizationExtender1.SetLocalizationComment(this._provinceText, null);
			this.localizationExtender1.SetLocalizingId(this._provinceText, "CollectionSettingsDialog._provinceText");
			this._provinceText.Location = new System.Drawing.Point(32, 112);
			this._provinceText.Name = "_provinceText";
			this._provinceText.Size = new System.Drawing.Size(214, 25);
			this._provinceText.TabIndex = 4;
			//
			// _countryText
			//
			this._countryText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._countryText, null);
			this.localizationExtender1.SetLocalizationComment(this._countryText, null);
			this.localizationExtender1.SetLocalizingId(this._countryText, "CollectionSettingsDialog._countryText");
			this._countryText.Location = new System.Drawing.Point(32, 45);
			this._countryText.Name = "_countryText";
			this._countryText.Size = new System.Drawing.Size(214, 25);
			this._countryText.TabIndex = 3;
			//
			// _countryLabel
			//
			this._countryLabel.AutoSize = true;
			this._countryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._countryLabel, null);
			this.localizationExtender1.SetLocalizationComment(this._countryLabel, null);
			this.localizationExtender1.SetLocalizationPriority(this._countryLabel, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._countryLabel, "CollectionSettingsDialog.label7");
			this._countryLabel.Location = new System.Drawing.Point(28, 23);
			this._countryLabel.Name = "_countryLabel";
			this._countryLabel.Size = new System.Drawing.Size(59, 19);
			this._countryLabel.TabIndex = 2;
			this._countryLabel.Text = "Country";
			//
			// _districtLabel
			//
			this._districtLabel.AutoSize = true;
			this._districtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._districtLabel, null);
			this.localizationExtender1.SetLocalizationComment(this._districtLabel, null);
			this.localizationExtender1.SetLocalizationPriority(this._districtLabel, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._districtLabel, "CollectionSettingsDialog.label5");
			this._districtLabel.Location = new System.Drawing.Point(28, 155);
			this._districtLabel.Name = "_districtLabel";
			this._districtLabel.Size = new System.Drawing.Size(55, 19);
			this._districtLabel.TabIndex = 1;
			this._districtLabel.Text = "District";
			//
			// _provinceLabel
			//
			this._provinceLabel.AutoSize = true;
			this._provinceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.localizationExtender1.SetLocalizableToolTip(this._provinceLabel, null);
			this.localizationExtender1.SetLocalizationComment(this._provinceLabel, null);
			this.localizationExtender1.SetLocalizationPriority(this._provinceLabel, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._provinceLabel, "CollectionSettingsDialog.label3");
			this._provinceLabel.Location = new System.Drawing.Point(28, 90);
			this._provinceLabel.Name = "_provinceLabel";
			this._provinceLabel.Size = new System.Drawing.Size(63, 19);
			this._provinceLabel.TabIndex = 0;
			this._provinceLabel.Text = "Province";
			//
			// _okButton
			//
			this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.localizationExtender1.SetLocalizableToolTip(this._okButton, null);
			this.localizationExtender1.SetLocalizationComment(this._okButton, null);
			this.localizationExtender1.SetLocalizingId(this._okButton, "Common.OKButton");
			this._okButton.Location = new System.Drawing.Point(534, 382);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(75, 23);
			this._okButton.TabIndex = 1;
			this._okButton.Text = "&OK";
			this._okButton.UseVisualStyleBackColor = true;
			this._okButton.Click += new System.EventHandler(this._okButton_Click);
			//
			// _restartReminder
			//
			this._restartReminder.AutoSize = true;
			this._restartReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._restartReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.localizationExtender1.SetLocalizableToolTip(this._restartReminder, null);
			this.localizationExtender1.SetLocalizationComment(this._restartReminder, null);
			this.localizationExtender1.SetLocalizationPriority(this._restartReminder, Localization.LocalizationPriority.Medium);
			this.localizationExtender1.SetLocalizingId(this._restartReminder, "CollectionSettingsDialog._restartMessage");
			this._restartReminder.Location = new System.Drawing.Point(9, 388);
			this._restartReminder.Name = "_restartReminder";
			this._restartReminder.Size = new System.Drawing.Size(290, 20);
			this._restartReminder.TabIndex = 19;
			this._restartReminder.Text = "Restart Bloom to use new settings.";
			this._restartReminder.Visible = false;
			//
			// settingsProtectionLauncherButton1
			//
			this.localizationExtender1.SetLocalizableToolTip(this.settingsProtectionLauncherButton1, null);
			this.localizationExtender1.SetLocalizationComment(this.settingsProtectionLauncherButton1, null);
			this.localizationExtender1.SetLocalizingId(this.settingsProtectionLauncherButton1, "CollectionSettingsDialog.SettingsProtectionLauncherButton");
			this.settingsProtectionLauncherButton1.Location = new System.Drawing.Point(13, 349);
			this.settingsProtectionLauncherButton1.Margin = new System.Windows.Forms.Padding(0);
			this.settingsProtectionLauncherButton1.Name = "settingsProtectionLauncherButton1";
			this.settingsProtectionLauncherButton1.Size = new System.Drawing.Size(257, 37);
			this.settingsProtectionLauncherButton1.TabIndex = 20;
			//
			// localizationExtender1
			//
			this.localizationExtender1.LocalizationManagerId = "Bloom";
			//
			// CollectionSettingsDialog
			//
			this.AcceptButton = this._okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 417);
			this.Controls.Add(this.settingsProtectionLauncherButton1);
			this.Controls.Add(this._restartReminder);
			this.Controls.Add(this._okButton);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.localizationExtender1.SetLocalizableToolTip(this, null);
			this.localizationExtender1.SetLocalizationComment(this, null);
			this.localizationExtender1.SetLocalizingId(this, "CollectionSettingsDialog.WindowTitle");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CollectionSettingsDialog";
			this.Text = "Settings";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.localizationExtender1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button _okButton;
		protected System.Windows.Forms.Label _language1Label;
		private System.Windows.Forms.LinkLabel _changeLanguage3Link;
		private System.Windows.Forms.LinkLabel _changeLanguage2Link;
		private System.Windows.Forms.LinkLabel _changeLanguage1Link;
		protected System.Windows.Forms.Label _nationalLanguage2Label;
		protected System.Windows.Forms.Label _language3Label;
		protected System.Windows.Forms.Label _nationalLanguage1Label;
		protected System.Windows.Forms.Label _language2Label;
		protected System.Windows.Forms.Label _vernacularLanguageName;
		private System.Windows.Forms.Label _xmatterPackLabel;
		private System.Windows.Forms.ComboBox _xmatterPackCombo;
		private System.Windows.Forms.TextBox _districtText;
		private System.Windows.Forms.TextBox _provinceText;
		private System.Windows.Forms.TextBox _countryText;
		private System.Windows.Forms.Label _countryLabel;
		private System.Windows.Forms.Label _districtLabel;
		private System.Windows.Forms.Label _provinceLabel;
		private System.Windows.Forms.LinkLabel _removeLanguage3Link;
		private System.Windows.Forms.Label _restartReminder;
		private Palaso.UI.WindowsForms.SettingProtection.SettingsProtectionLauncherButton settingsProtectionLauncherButton1;
		private System.Windows.Forms.Button _aboutLanguageSettingsButton;
		private System.Windows.Forms.Button _aboutBookMakingSettingsButton;
		private System.Windows.Forms.Button _aboutProjectInformationSetingsButton;
		private Localization.UI.LocalizationExtender localizationExtender1;
	}
}