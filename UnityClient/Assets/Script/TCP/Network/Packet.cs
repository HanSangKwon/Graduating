using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace UnityGame
{

    public interface PacketInterface
    {
        void encode();
        void decode(byte[] packet, ref int offset);

        Int64 type();
        MemoryStream getStream();
    }

    public class PacketData
    {
        protected MemoryStream packet_ = new MemoryStream();

        ~PacketData()
        {
            packet_ = null;
        }
    }

}
