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

        public void S_ANS_ENTER_GAME(PacketInterface rowPacket)
        {

            //Debug.Log("");
            PK_S_ANS_ENTER_GAME packet = (PK_S_ANS_ENTER_GAME)rowPacket;
            //수정!!!  데베 연결이 끝나면 아이피 포트 서버에서 받아오기. 
            GameObject.Find("GameNetWork").GetComponent<GameNetWork>().Open("127.0.0.1", 9200 );
            GameObject.Find("ChattingNetWork").GetComponent<ChattingNetWork>().Open("127.0.0.1", 9100);


            PK_C_REQ_REGIST_NAME packet_ = new PK_C_REQ_REGIST_NAME();
            packet_.name_ = packet.name_;

            GameObject.Find("ChattingNetWork").GetComponent<ChattingNetWork>().sendPacket(packet_);

            GameObject.Find("LoginNetWork").GetComponent<LoginNetWork>().set_My_name(packet_.name_);
            GameObject.Find("LoginNetWork").GetComponent<LoginNetWork>().disconnect();
            //로비로 이동!
            SceneManager.LoadScene(1);

        }

        public override void S_ANS_EXIT(PacketInterface rowPacket)
        {

        }


    }
}
