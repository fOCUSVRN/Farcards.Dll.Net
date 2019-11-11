using Farcards.Dll.Net.Unmanaged;
using System.Collections.Generic;

namespace Farcards.Dll.Net.Managed
{
    public class ExtDllMethodResult
    {
        public int Result { get; set; }
    }


    public class ExtDllExtResult: ExtDllMethodResult
    {
        public string OutBuf { get; set; }
        public ushort OutKind { get; set; }

    }

    public class GetCardInfoExResult : ExtDllExtResult
    {
        public PCard29Info Info { get; set; }
    }

    public class FindEmailResult: ExtDllMethodResult
    {
        public uint Account { get; set; }
        public long CardId { get; set; }
        public string Name { get; set; }
    }

    public class GetCardImageExResult : ExtDllMethodResult
    {
       public string FileName { get; set; }
    }

    public class TransactionsExResult : ExtDllExtResult { }


    public abstract class ManagedFarcards
    {
        public abstract GetCardInfoExResult GetCardInfoEx(string inpBuf);

        public abstract TransactionsExResult TransactionsEx(string inpBuf);

        public abstract void Init();

        public abstract void Done();
    }

    public abstract class ManagedFarcardsFull
    {
        public abstract GetCardInfoExResult GetCardInfoEx(long card, uint restaurant, uint unitNo, string inpBuf);

        public abstract TransactionsExResult TransactionsEx(List<RKTransactInfoEx> transactions, string inpBuf);

        public abstract FindEmailResult FindEmail(string email);
        public abstract GetCardImageExResult GetCardImageEx(long card);

        public abstract void Init();

        public abstract void Done();
    }
}
