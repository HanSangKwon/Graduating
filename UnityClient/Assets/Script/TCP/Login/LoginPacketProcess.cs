using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace UnityGame
{
    class LoginPacketProcess : PacketProcess
    {
        LoginContents contents_ = null;

        public LoginPacketProcess()
        {
            contents_ = new LoginContents();
        }

        public override void run(PacketInterface packet)
        {
            PacketType type = (PacketType)packet.type();

            Debug.Log("받은 로그인 패킷" + type);
            switch (type)
            {
                case PacketType.E_S_ANS_ENTER_GAME:
                    contents_.S_ANS_ENTER_GAME(packet);
                    return;

                case PacketType.E_S_ANS_EXIT:
                    return;

            }
            if (base.defaultRun(packet) == false)
            {
#if DEBUG
                Debug.Log("잘못된 패킷이 수신되었습니다 : " );
                Debug.Log(type);
#endif
            }
        }
    }
}
