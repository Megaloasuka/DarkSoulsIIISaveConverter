using SoulsFormats;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace DarkSoulsIIISaveConverter
{
	public class SavePanel : UserControl, IComponentConnector
	{
		internal GroupBox gbxSave;

		internal TextBox txtPath;

		internal Label lblSteamID;

		internal TextBox txtSteamID;

		internal StackPanel splSlots;

		internal Button btnSave;

		private bool _contentLoaded;

		public string Header
		{
			get
			{
				return gbxSave.Header.ToString();
			}
			set
			{
				gbxSave.Header = value;
			}
		}

		private SL2 Save => base.DataContext as SL2;

		public SavePanel()
		{
			InitializeComponent();
		}

		public void Load(string path, bool silent = false)
		{
			try
			{
				base.DataContext = new SL2(path);
				if (!silent)
				{
					SystemSounds.Asterisk.Play();
				}
			}
			catch (Exception arg)
			{
				if (!silent)
				{
					MessageBox.Show($"Error loading save:\n{path}\n\n{arg}", "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
				}
			}
		}

		private void UserControl_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effects = DragDropEffects.Copy;
			}
		}

		private void UserControl_Drop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				Load(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
			}
		}

		private void GbxSave_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			splSlots.Children.Clear();
			for (int i = 0; i < 10; i++)
			{
				SaveSlot dataContext = null;
				if (Save.Menu.OccupiedSlots[i])
				{
					dataContext = Save.Slots[i];
				}
				splSlots.Children.Add(new SlotPanel
				{
					DataContext = dataContext
				});
			}
		}

		private void BtnSave_Click(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < 10; i++)
			{
				SaveSlot saveSlot = ((SlotPanel)splSlots.Children[i]).DataContext as SaveSlot;
				if (saveSlot == null)
				{
					Save.Menu.OccupiedSlots[i] = false;
					continue;
				}
				Save.Menu.OccupiedSlots[i] = true;
				Save.Slots[i] = saveSlot;
			}
			try
			{
				SFUtil.Backup(Save.Path, false);
				Save.Write();
				SystemSounds.Asterisk.Play();
			}
			catch (Exception arg)
			{
				MessageBox.Show($"Error saving save:\n{Save.Path}\n\n{arg}", "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!_contentLoaded)
			{
				_contentLoaded = true;
				Uri resourceLocator = new Uri("/DarkSoulsIIISaveConverter;component/savepanel.xaml", UriKind.Relative);
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
				((SavePanel)target).DragEnter += UserControl_DragEnter;
				((SavePanel)target).Drop += UserControl_Drop;
				break;
			case 2:
				gbxSave = (GroupBox)target;
				gbxSave.DataContextChanged += GbxSave_DataContextChanged;
				break;
			case 3:
				txtPath = (TextBox)target;
				break;
			case 4:
				lblSteamID = (Label)target;
				break;
			case 5:
				txtSteamID = (TextBox)target;
				break;
			case 6:
				splSlots = (StackPanel)target;
				break;
			case 7:
				btnSave = (Button)target;
				btnSave.Click += BtnSave_Click;
				break;
			default:
				_contentLoaded = true;
				break;
			}
		}
	}
}
