using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace UnityGame
{
    public class ChattingPacketProcess : PacketProcess
    {
        ChattingContents contents_ = null;

        public ChattingPacketProcess()
        {
            contents_ = new ChattingContents();
        }

        public override void run(PacketInterface packet)
        {

            PacketType type = (PacketType)packet.type();
            Debug.Log("받은 채팅 패킷" + type);
            switch (type)
            {
                case PacketType.E_S_ANS_CHATTING:
                    contents_.S_ANS_CHATTING(packet);
                    return;

            }

            if (base.defaultRun(packet) == false)
            {
#if DEBUG
                Debug.Log("잘못된 패킷이 수신되었습니다 : " );
                
#endif
            }
        }
    }
}
