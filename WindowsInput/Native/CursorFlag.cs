using System;

namespace WindowsInput.Native
{
	/// <summary>
	/// The cursor state. CursorFlag is a part of CURSORINFO structure (DWORD flags) (winuser.h). (See: https://docs.microsoft.com/ru-ru/windows/win32/api/winuser/ns-winuser-cursorinfo)
	/// </summary>
	[Flags]
	public enum CursorFlag : Int32
	{
		/// <summary>
		/// The cursor is hidden.
		/// </summary>
		Hidden = 0x0000,

		/// <summary>
		/// The cursor is showing.
		/// </summary>
		Visible = 0x0001,

		/// <summary>
		/// Windows 8: The cursor is suppressed. This flag indicates that the system is not drawing the cursor because the user is providing input through touch or pen instead of the mouse. 
		/// </summary>
		Suppressed = 0x002
	}
}