﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Base.Packets;

namespace Game.Server.Packets.Client
{
    [PacketHandler((int)ePackageType.MARRY_CMD,"礼堂数据")]
    public class MarryDataHandler:IPacketHandler
    {
        public int HandlePacket(GameClient client, GSPacketIn packet)
        {
            if (client.Player.CurrentMarryRoom != null)
            {
                client.Player.CurrentMarryRoom.ProcessData(client.Player, packet);
            }

            return 0;
        }

    }
}
