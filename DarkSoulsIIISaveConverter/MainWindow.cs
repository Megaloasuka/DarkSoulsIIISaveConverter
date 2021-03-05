using DarkSoulsIIISaveConverter.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Markup;

namespace DarkSoulsIIISaveConverter
{
	public class MainWindow : Window, IComponentConnector
	{
		private static readonly Settings Settings = Settings.Default;

		internal SavePanel savePanel1;

		internal SavePanel savePanel2;

		private bool _contentLoaded;

		public MainWindow()
		{
			InitializeComponent();
			base.Left = Settings.WindowLeft;
			base.Top = Settings.WindowTop;
			base.Width = Settings.WindowWidth;
			base.Height = Settings.WindowHeight;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			base.Title = "DarkSoulsIIISaveConverter ºÚ°µÖ®»êIII´æµµ×ª»»Æ÷ " + System.Windows.Forms.Application.ProductVersion;
			if (Settings.WindowMaximized)
			{
				base.WindowState = WindowState.Maximized;
			}
			if (Settings.Save1Path != "")
			{
				savePanel1.Load(Settings.Save1Path, silent: true);
			}
			if (Settings.Save2Path != "")
			{
				savePanel2.Load(Settings.Save2Path, silent: true);
			}
		}

		private void Window_Closing(object sender, CancelEventArgs e)
		{
			Settings.WindowMaximized = (base.WindowState == WindowState.Maximized);
			if (base.WindowState == WindowState.Normal)
			{
				Settings.WindowLeft = base.Left;
				Settings.WindowTop = base.Top;
				Settings.WindowWidth = base.Width;
				Settings.WindowHeight = base.Height;
			}
			else
			{
				Settings.WindowLeft = base.RestoreBounds.Left;
				Settings.WindowTop = base.RestoreBounds.Top;
				Settings.WindowWidth = base.RestoreBounds.Width;
				Settings.WindowHeight = base.RestoreBounds.Height;
			}
			if (savePanel1.DataContext != null)
			{
				Settings.Save1Path = ((SL2)savePanel1.DataContext).Path;
			}
			if (savePanel2.DataContext != null)
			{
				Settings.Save2Path = ((SL2)savePanel2.DataContext).Path;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!_contentLoaded)
			{
				_contentLoaded = true;
				Uri resourceLocator = new Uri("/DarkSoulsIIISaveConverter;component/mainwindow.xaml", UriKind.Relative);
				System.Windows.Application.LoadComponent(this, resourceLocator);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((MainWindow)target).Loaded += Window_Loaded;
				((MainWindow)target).Closing += Window_Closing;
				break;
			case 2:
				savePanel1 = (SavePanel)target;
				break;
			case 3:
				savePanel2 = (SavePanel)target;
				break;
			default:
				_contentLoaded = true;
				break;
			}
		}
	}
}
