using System.Runtime.InteropServices;

namespace WindowsInput.Native
{
	/// <summary>
	/// The structure that receives the screen coordinates of the cursor. See: (https://docs.microsoft.com/en-us/previous-versions/dd162805(v=vs.85)
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct Point
	{
		/// <summary>
		/// Make a point with the specified coordinates.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// The X coordinate of mouse cursor on virtual desktop.
		/// </summary>
		public readonly int X;
		/// <summary>
		/// The Y coordinate of mouse cursor on virtual desktop.
		/// </summary>
		public readonly int Y;
	}
}