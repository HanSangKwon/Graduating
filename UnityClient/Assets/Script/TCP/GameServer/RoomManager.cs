using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UnityGame
{

    public class RoomManager : MonoBehaviour
    {

        public void btnIntoRoom()
        {
            PK_C_REQ_INTO_ROOM packet_ = new PK_C_REQ_INTO_ROOM();

            packet_.roomNum = 1;

            GameObject.Find("GameNetWork").GetComponent<GameNetWork>().sendPacket(packet_);
        }

    }

}