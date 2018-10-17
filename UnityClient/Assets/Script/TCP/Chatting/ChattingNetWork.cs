using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityGame
{
    public class ChattingNetWork : MonoBehaviour
    {
        protected Network network_;

        private void Start()
        {
            DontDestroyOnLoad(this);
            if (network_ == null)
                network_ = new Network();
        }

        private void OnDestroy()
        {
            PK_C_REQ_CHAT_EXIT packet = new PK_C_REQ_CHAT_EXIT();
            sendPacket(packet);
            disconnect();
        }

        public bool connectToServer(string ip, uint port)
        {
            return network_.connect(ip, port);
        }

        public void Open(string ip, uint port)
        {
            if (!connectToServer(ip, port))
            {
                Debug.Log("채팅 서버 연결에 실패 했습니다..");
            }
            network_.setPacketProcess(new ChattingPacketProcess());
            StartCoroutine(recv());
        }

        public NET_STATE GetState()
        {
            return network_.State();
        }

        public void disconnect()
        {
            network_.close();
        }

        public void sendPacket(PacketInterface packet)
        {
            network_.sendPacket(packet);
        }

        IEnumerator recv()
        {
            while (true)
            {
                network_.receive();
                yield return null;
            }
        }
    }
}

