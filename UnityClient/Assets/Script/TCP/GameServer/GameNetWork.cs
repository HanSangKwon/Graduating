using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGame
{
    public class GameNetWork : MonoBehaviour
    {

        protected Network network_;
        public string NickName;
        private string loginIp_ = "127.0.0.1";
        private uint loginPort_ = 9000;

        private void Start()
        {
            DontDestroyOnLoad(this);
            if (network_ == null)
                network_ = new Network();

            Open(loginIp_, loginPort_);

        }

        private void OnDestroy()
        {
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
                Debug.Log("게임 서버 연결에 실패 했습니다..");
            }
            network_.setPacketProcess(new GamePacketProcess());
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

        public void RegistMyName(string name)
        {
            NickName = name;
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
