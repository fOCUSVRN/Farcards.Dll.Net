using System.Runtime.InteropServices;

namespace Farcards.Dll.Net.Unmanaged
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RKTransactInfoEx
    {
        public ushort Size;
        public long Card;
        public long PersonID;
        public uint Account;
        public byte Kind;
        public long Summa;
        public ushort Restaurant;
        public uint RKDate;
        public byte RKUnit;
        public uint RKCheck;
        public long VatSumA;
        public ushort VatPrcA;
        public long VatSumB;
        public ushort VatPrcB;
        public long VatSumC;
        public ushort VatPrcC;
        public long VatSumD;
        public ushort VatPrcD;
        public long VatSumE;
        public ushort VatPrcE;
        public long VatSumF;
        public ushort VatPrcF;
        public long VatSumG;
        public ushort VatPrcG;
        public long VatSumH;
        public ushort VatPrcH;
        public uint RKCheckB;
    }
}
