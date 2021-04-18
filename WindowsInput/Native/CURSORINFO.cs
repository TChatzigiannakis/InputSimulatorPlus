using System;

namespace WindowsInput.Native
{
#pragma warning disable 649
	/// <summary>
	/// Contains global cursor information. See: (https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-cursorinfo)
	/// </summary>
	public struct CURSORINFO
	{
		/// <summary>
		/// The size of the structure in bytes. The caller must set this to sizeof(CURSORINFO).
		/// </summary>
		public Int32 cbSize;

		/// <summary>
		/// The cursor state. This parameter can be one of the following values.
		/// </summary>
		public CursorFlag flags;

		/// <summary>
		/// A handle to the cursor.
		/// </summary>
		public IntPtr hCursor;

		/// <summary>
		/// The structure that receives the screen coordinates of the cursor.
		/// </summary>
		public Point ptScreenPos;
	}
#pragma warning restore 649
}