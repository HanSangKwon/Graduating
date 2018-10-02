using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


namespace UnityGame
{
    class LoginContents : ContentsProcess
    {
        public void S_ANS_ID_PW_FAIL(PacketInterface rowPacket)
        {
            Debug.Log("로그인 실패");
        }

        public void S_ANS_ID_PW_SUCCESS_CHATTING(PacketInterface rowPacket)
        {

        }

        public void S_ANS_ID_PW_SUCCESS_GAME(PacketInterface rowPacket)
        {

     
        }

        public override void S_ANS_EXIT(PacketInterface rowPacket)
        {

        }


    }
}
