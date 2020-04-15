namespace Intersect.Network.Packets.Server
{

    public class CraftingTablePacket : CerasPacket
    {

        public CraftingTablePacket(string tableData, bool close, string reqcheck)
        {
            TableData = tableData;
            Close = close;
            ReqCheck = reqcheck;
        }

        public string TableData { get; set; }

        public bool Close { get; set; }

        public string ReqCheck { get; set; }

    }

}
