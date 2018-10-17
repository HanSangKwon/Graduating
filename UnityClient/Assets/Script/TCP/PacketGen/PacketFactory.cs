using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UnityGame
{
    public static class PacketFactory
    {
        public static PacketInterface getPacket(Int64 packetType) 
        {
            switch ((PacketType)packetType)
            {
                case PacketType.E_C_REQ_EXIT:    return new PK_C_REQ_EXIT();
                case PacketType.E_S_ANS_EXIT:    return new PK_S_ANS_EXIT();
                case PacketType.E_C_REQ_CHAT_EXIT:    return new PK_C_REQ_CHAT_EXIT();
                case PacketType.E_S_ANS_CHATEXIT:    return new PK_S_ANS_CHATEXIT();
                case PacketType.E_C_REQ_GAME_EXIT:    return new PK_C_REQ_GAME_EXIT();
                case PacketType.E_S_ANS_GAME_EXIT:    return new PK_S_ANS_GAME_EXIT();
                case PacketType.E_I_NOTIFY_TERMINAL:    return new PK_I_NOTIFY_TERMINAL();
                case PacketType.E_C_NOTIFY_HEARTBEAT:    return new PK_C_NOTIFY_HEARTBEAT();
                case PacketType.E_C_REQ_ID_PW:    return new PK_C_REQ_ID_PW();
                case PacketType.E_S_ANS_ID_PW_FAIL:    return new PK_S_ANS_ID_PW_FAIL();
                case PacketType.E_S_ANS_ID_PW_SUCCESS:    return new PK_S_ANS_ID_PW_SUCCESS();
                case PacketType.E_I_DB_REQ_ID_PW:    return new PK_I_DB_REQ_ID_PW();
                case PacketType.E_I_DB_ANS_ID_PW:    return new PK_I_DB_ANS_ID_PW();
                case PacketType.E_I_CHTTING_NOTIFY_ID:    return new PK_I_CHTTING_NOTIFY_ID();
                case PacketType.E_I_DB_REQ_LOAD_DATA:    return new PK_I_DB_REQ_LOAD_DATA();
                case PacketType.E_I_DB_ANS_PARSE_DATA:    return new PK_I_DB_ANS_PARSE_DATA();
                case PacketType.E_I_LOGIN_NOTIFY_ID_LOADED:    return new PK_I_LOGIN_NOTIFY_ID_LOADED();
                case PacketType.E_C_REQ_REGIST_NAME:    return new PK_C_REQ_REGIST_NAME();
                case PacketType.E_S_ANS_REGIST_NAME:    return new PK_S_ANS_REGIST_NAME();
                case PacketType.E_C_REQ_CHATTING:    return new PK_C_REQ_CHATTING();
                case PacketType.E_S_ANS_CHATTING:    return new PK_S_ANS_CHATTING();
                case PacketType.E_C_REQ_ENTER_GAME:    return new PK_C_REQ_ENTER_GAME();
                case PacketType.E_S_ANS_ENTER_GAME:    return new PK_S_ANS_ENTER_GAME();
            }
            return null;
        }
    }
}
