using System;

namespace GFF.Component.NAudio.Wave
{
	public interface IMp3FrameDecompressor : IDisposable
	{
		WaveFormat OutputFormat
		{
			get;
		}

		int DecompressFrame(Mp3Frame frame, byte[] dest, int destOffset);

		void Reset();
	}
}
