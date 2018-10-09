using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace UnityGame
{
    class ChattingContents : ContentsProcess
    {
        public void S_ANS_CHATTING(PacketInterface rowPacket)
        {
            Debug.Log("Enter PK_S_ANS_CHATTING");

            PK_S_ANS_CHATTING packet = (PK_S_ANS_CHATTING)rowPacket;

            //받은 내용 표시하기.
            ChatWindow.Instance.packet_name = packet.name_;
            ChatWindow.Instance.packet_text = packet.text_;
            ChatWindow.Instance.SendMessageToChat(packet.name_ + packet.text_);

        }
        //연결끊기 (사용안함.)
        public override void S_ANS_EXIT(PacketInterface rowPacket)
        {            
        }
    }
}
