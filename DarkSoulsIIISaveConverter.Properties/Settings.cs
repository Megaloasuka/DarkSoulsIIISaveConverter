using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DarkSoulsIIISaveConverter.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => defaultInstance;

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool UpgradeRequired
		{
			get
			{
				return (bool)this["UpgradeRequired"];
			}
			set
			{
				this["UpgradeRequired"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public double WindowLeft
		{
			get
			{
				return (double)this["WindowLeft"];
			}
			set
			{
				this["WindowLeft"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("922")]
		public double WindowWidth
		{
			get
			{
				return (double)this["WindowWidth"];
			}
			set
			{
				this["WindowWidth"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool WindowMaximized
		{
			get
			{
				return (bool)this["WindowMaximized"];
			}
			set
			{
				this["WindowMaximized"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Save1Path
		{
			get
			{
				return (string)this["Save1Path"];
			}
			set
			{
				this["Save1Path"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Save2Path
		{
			get
			{
				return (string)this["Save2Path"];
			}
			set
			{
				this["Save2Path"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public double WindowTop
		{
			get
			{
				return (double)this["WindowTop"];
			}
			set
			{
				this["WindowTop"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("706")]
		public double WindowHeight
		{
			get
			{
				return (double)this["WindowHeight"];
			}
			set
			{
				this["WindowHeight"] = value;
			}
		}
	}
}
