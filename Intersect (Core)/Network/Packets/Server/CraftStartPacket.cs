namespace Intersect.Network.Packets.Server
{

    public class CraftStartPacket : CerasPacket
    {

        public CraftStartPacket(System.Guid craftData, bool canstart)
        {
            CraftData = craftData;
            Canstart = canstart;
        }

        public System.Guid CraftData { get; set; }

        public bool Canstart { get; set; }

    }

}