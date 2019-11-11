using System.Runtime.InteropServices;

namespace Farcards.Dll.Net.Unmanaged
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PImageInfo
    {
        public ushort Size;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string FileName;
    }
}
