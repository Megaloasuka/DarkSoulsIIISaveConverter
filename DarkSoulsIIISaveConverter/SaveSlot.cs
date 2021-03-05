using SoulsFormats;
using System;
using System.IO;

namespace DarkSoulsIIISaveConverter
{
	[Serializable]
	public class SaveSlot
	{
		public string CharName
		{
			get;
		}

		public int SoulLevel
		{
			get;
		}

		public int PlaytimeSeconds
		{
			get;
		}

		public byte[] MenuData
		{
			get;
		}

		public byte[] SlotData
		{
			get;
		}

		public SaveSlot(byte[] menuData, byte[] slotData)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			MenuData = menuData;
			SlotData = slotData;
			using (MemoryStream memoryStream = new MemoryStream(menuData))
			{
				BinaryReaderEx val = (BinaryReaderEx)(object)new BinaryReaderEx(false, (Stream)memoryStream);
				CharName = val.ReadFixStrW(32);
				val.ReadInt16();
				SoulLevel = val.ReadInt32();
				PlaytimeSeconds = val.ReadInt32();
			}
		}

		public void WriteSteamID(int steamID)
		{
			byte[] bytes = BitConverter.GetBytes(steamID);
			int num = BitConverter.ToInt32(SlotData, 88);
			Buffer.BlockCopy(bytes, 0, SlotData, num + 111, bytes.Length);
		}
	}
}
