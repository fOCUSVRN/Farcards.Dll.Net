using System.Runtime.InteropServices;

namespace Farcards.Dll.Net.Unmanaged
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PCard29Info
    {
        public ushort Size;
        public byte Deleted;
        public byte Seize;
        public byte StopDate;
        public byte Holy;
        public byte Manager;
        public byte Locked;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string WhyLock;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
        public string Holder;
        public long HolderID;
        public uint CardNumber;
        public uint Unpay;
        public ushort Bonus;
        public ushort Discount;
        public long DiscLimit;
        public long Summa;
        public long Sum2;
        public long Sum3;
        public long Sum4;
        public long Sum5;
        public long Sum6;
        public long Sum7;
        public long Sum8;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string DopInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string ScreenInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string PrintInfo;
    }
}
