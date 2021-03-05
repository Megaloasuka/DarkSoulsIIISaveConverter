using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace DarkSoulsIIISaveConverter
{
	public class SlotPanel : UserControl, IComponentConnector
	{
		internal SlotPanel uclParent;

		internal TextBlock lblName;

		internal TextBlock lblLevel;

		internal TextBlock lblTime;

		private bool _contentLoaded;

		public SlotPanel()
		{
			InitializeComponent();
		}

		private void UclParent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Focus();
		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			RoutedCommand routedCommand = (RoutedCommand)e.Command;
			if (routedCommand.Name == "Copy" && base.DataContext != null)
			{
				Clipboard.SetData("SlotPanel", base.DataContext);
			}
			else if (routedCommand.Name == "Paste" && Clipboard.ContainsData("SlotPanel"))
			{
				base.DataContext = (Clipboard.GetData("SlotPanel") as SaveSlot);
			}
			else if (routedCommand.Name == "Delete")
			{
				base.DataContext = null;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!_contentLoaded)
			{
				_contentLoaded = true;
				Uri resourceLocator = new Uri("/DarkSoulsIIISaveConverter;component/slotpanel.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				uclParent = (SlotPanel)target;
				uclParent.MouseLeftButtonDown += UclParent_MouseLeftButtonDown;
				break;
			case 2:
				((CommandBinding)target).Executed += CommandBinding_Executed;
				break;
			case 3:
				((CommandBinding)target).Executed += CommandBinding_Executed;
				break;
			case 4:
				((CommandBinding)target).Executed += CommandBinding_Executed;
				break;
			case 5:
				lblName = (TextBlock)target;
				break;
			case 6:
				lblLevel = (TextBlock)target;
				break;
			case 7:
				lblTime = (TextBlock)target;
				break;
			default:
				_contentLoaded = true;
				break;
			}
		}
	}
}
