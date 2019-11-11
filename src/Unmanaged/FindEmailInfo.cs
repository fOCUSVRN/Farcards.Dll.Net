using System.Runtime.InteropServices;

namespace Farcards.Dll.Net.Unmanaged
{
    /*
     type
  tAccountInfoRecForEmail = packed record
    Size: Word;
    Account: DWORD;
    CardID: Int64;
    Name: array [0 .. 39] of ansichar; // asciiz
  end;
  */

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FindEmailInfo
    {
        public ushort Size;
        public uint Account;
        public long CardID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        internal string Name;
    }
}
