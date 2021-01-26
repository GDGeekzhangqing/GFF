using System;

namespace GFF.Component.NAudio.CoreAudioApi
{
	[Flags]
	public enum AudioClientBufferFlags
	{
		None = 0,
		DataDiscontinuity = 1,
		Silent = 2,
		TimestampError = 4
	}
}
