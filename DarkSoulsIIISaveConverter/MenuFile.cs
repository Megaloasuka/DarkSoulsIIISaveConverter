using SoulsFormats;
using System.Collections.Generic;
using System.IO;

namespace DarkSoulsIIISaveConverter
{
	internal class MenuFile
	{
		private byte[] Data;

		public int SteamID
		{
			get;
			set;
		}

		public bool[] OccupiedSlots
		{
			get;
			set;
		}

		public byte[][] SlotData
		{
			get;
			set;
		}

		public MenuFile(byte[] data)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			Data = data;
			using (MemoryStream memoryStream = new MemoryStream(Data))
			{
				BinaryReaderEx val = (BinaryReaderEx)(object)new BinaryReaderEx(false, (Stream)memoryStream);
				SteamID = val.GetInt32(8L);
				OccupiedSlots = val.GetBooleans(4248L, 10);
				SlotData = new byte[10][];
				for (int i = 0; i < 10; i++)
				{
					SlotData[i] = val.GetBytes((long)(4258 + 554 * i), 554);
				}
			}
		}

		public byte[] Write()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryWriterEx val = (BinaryWriterEx)(object)new BinaryWriterEx(false, (Stream)memoryStream);
				val.WriteBytes(Data);
				val.set_Position(8L);
				val.WriteInt32(SteamID);
				val.set_Position(4248L);
				val.WriteBooleans((IList<bool>)OccupiedSlots);
				for (int i = 0; i < 10; i++)
				{
					val.set_Position((long)(4258 + 554 * i));
					val.WriteBytes(SlotData[i]);
				}
				return val.FinishBytes();
			}
		}
	}
}
