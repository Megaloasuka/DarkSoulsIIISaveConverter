using DarkSoulsIIISaveConverter.Properties;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace DarkSoulsIIISaveConverter
{
	public class App : Application
	{
		private bool _contentLoaded;

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			Settings @default = Settings.Default;
			if (@default.UpgradeRequired)
			{
				@default.Upgrade();
				@default.UpgradeRequired = false;
				@default.Save();
			}
		}

		private void Application_Exit(object sender, ExitEventArgs e)
		{
			Settings.Default.Save();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!_contentLoaded)
			{
				_contentLoaded = true;
				base.Startup += Application_Startup;
				base.Exit += Application_Exit;
				base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
				Uri resourceLocator = new Uri("/DarkSoulsIIISaveConverter;component/app.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void Main()
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}
