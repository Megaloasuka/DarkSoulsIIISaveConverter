using SoulsFormats;
using System;
using System.Text.RegularExpressions;

namespace DarkSoulsIIISaveConverter
{
	internal class SL2
	{
		private BND4 bnd;

		public string Path
		{
			get;
			set;
		}

		public int SteamID
		{
			get
			{
				return Menu.SteamID;
			}
			set
			{
				Menu.SteamID = value;
			}
		}

		public MenuFile Menu
		{
			get;
		}

		public SaveSlot[] Slots
		{
			get;
		}

		public byte[] Regulation
		{
			get;
		}

		public SL2(string path)
		{
			Path = path;
			bnd = SoulsFile<BND4>.Read(path);
			if (bnd.get_Files().Count != 12)
			{
				throw new NotSupportedException($"Unexpected number of files in SL2: {bnd.get_Files().Count}");
			}
			for (int i = 0; i < 12; i++)
			{
				BinderFile val = bnd.get_Files()[i];
				if (!Regex.IsMatch(val.get_Name(), $"^USER_DATA{i:D3}$"))
				{
					throw new NotSupportedException("Unexpected filename in SL2: " + val.get_Name());
				}
			}
			Menu = new MenuFile(Decrypt(bnd.get_Files()[10]));
			Regulation = Decrypt(bnd.get_Files()[11]);
			Slots = new SaveSlot[10];
			for (int j = 0; j < 10; j++)
			{
				Slots[j] = new SaveSlot(Menu.SlotData[j], Decrypt(bnd.get_Files()[j]));
			}
		}

		public void Write()
		{
			for (int i = 0; i < 10; i++)
			{
				SaveSlot saveSlot = Slots[i];
				saveSlot.WriteSteamID(SteamID);
				bnd.get_Files()[i].set_Bytes(Encrypt(saveSlot.SlotData));
				Menu.SlotData[i] = Slots[i].MenuData;
			}
			bnd.get_Files()[10].set_Bytes(Encrypt(Menu.Write()));
			bnd.get_Files()[11].set_Bytes(Encrypt(Regulation));
			((SoulsFile<BND4>)(object)bnd).Write(Path);
		}

		private static byte[] Decrypt(BinderFile file)
		{
			return SFUtil.DecryptSL2File(file.get_Bytes(), SFUtil.GetDS3SaveKey());
		}

		private static byte[] Encrypt(byte[] bytes)
		{
			return SFUtil.EncryptSL2File(bytes, SFUtil.GetDS3SaveKey());
		}
	}
}
