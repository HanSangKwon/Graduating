using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityGame
{
    class GameContents : ContentsProcess
    {

        public void S_ANS_ENTER_GAME(PacketInterface rowPacket)
        {
            SceneManager.LoadScene(2);

        }

     

        public void PK_S_ANS_GAME_EXIT(PacketInterface rowPacket)
        {
        }

        public override void S_ANS_EXIT(PacketInterface rowPacket)
        {

        }
    }
}
