﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bloom.Properties {


	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

		private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

		public static Settings Default {
			get {
				return defaultInstance;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("True")]
		public bool FirstTimeRun {
			get {
				return ((bool)(this["FirstTimeRun"]));
			}
			set {
				this["FirstTimeRun"] = value;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public global::Bloom.ToPalaso.MostRecentPathsList MruProjects {
			get {
				return ((global::Bloom.ToPalaso.MostRecentPathsList)(this["MruProjects"]));
			}
			set {
				this["MruProjects"] = value;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("True")]
		public bool NeedUpgrade {
			get {
				return ((bool)(this["NeedUpgrade"]));
			}
			set {
				this["NeedUpgrade"] = value;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public global::Palaso.Reporting.ReportingSettings Reporting {
			get {
				return ((global::Palaso.Reporting.ReportingSettings)(this["Reporting"]));
			}
			set {
				this["Reporting"] = value;
			}
		}
	}
}
