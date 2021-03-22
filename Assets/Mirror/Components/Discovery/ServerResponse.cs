﻿using System;
using System.Net;

namespace Mirror.Discovery
{
    public struct ServerResponse : NetworkMessage
    {
        // The server that sent this
        // this is a property so that it is not serialized,  but the
        // client fills this up after we receive it
        public IPEndPoint EndPoint { get; set; }

        public Uri uri;

        // Prevent duplicate server appearance when a connection can be made via LAN on multiple NICs
        public long serverId;

        // weaver populates (de)serialize automatically
        public void Deserialize(NetworkReader reader) {}
        public void Serialize(NetworkWriter writer) {}
    }
}
