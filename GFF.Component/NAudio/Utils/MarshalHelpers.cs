using System;
using System.Runtime.InteropServices;

namespace GFF.Component.NAudio.Utils
{
	public static class MarshalHelpers
	{
		public static int SizeOf<T>()
		{
			return Marshal.SizeOf(typeof(T));
		}

		public static IntPtr OffsetOf<T>(string fieldName)
		{
			return Marshal.OffsetOf(typeof(T), fieldName);
		}

		public static T PtrToStructure<T>(IntPtr pointer)
		{
			return (T)((object)Marshal.PtrToStructure(pointer, typeof(T)));
		}
	}
}
