using System;

namespace Intersect.Network.Packets.Client
{

    public class CraftRequestPacket : CerasPacket
    {

        public CraftRequestPacket(Guid craftId)
        {
            CraftId = craftId;
        }

        public Guid CraftId { get; set; }

    }

}