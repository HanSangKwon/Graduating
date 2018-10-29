using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame
{
    public class GamePacketProcess : PacketProcess
    {
        GameContents contents_ = null;

        public GamePacketProcess()
        {
            contents_ = new GameContents();
        }

        public override void run(PacketInterface packet)
        {

            PacketType type = (PacketType)packet.type();

            Debug.Log("받은 게임 패킷" + type);
            switch (type)
            {
                case PacketType.E_S_ANS_INTO_ROOM:
                    contents_.S_ANS_ENTER_GAME(packet);
                    return;

                    // 패킷 타입에 따라 처리할 내용 작성하기!
            }

            if (base.defaultRun(packet) == false)
            {
#if DEBUG
                Debug.Log("잘못된 패킷이 수신되었습니다 : ");

#endif
            }
        }
    }
}
