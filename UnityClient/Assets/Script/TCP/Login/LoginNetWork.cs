using System.Collections;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;
using UnityEngine.UI;


namespace UnityGame
{

     public class LoginNetWork : MonoBehaviour
    {
        //HACK : 이곳 매직코드는 처음 접속하는
        //       로그인 서버 ip랑 port 번호임
        protected Network network_;
        private string loginIp_ = "127.0.0.1";
        private uint loginPort_ = 9000;

        LoginPacketProcess loginPacketProcess;


        private void Start()
        {
            //컨텐츠 등록하기!
            loginPacketProcess = new LoginPacketProcess();
            //로그인 서버에 접속하기!!
            Open();
            StartCoroutine(recv());
            DontDestroyOnLoad(this);
        }
        private void OnDestroy()
        {
            disconnect();
        }

        public bool connectToServer(string ip, uint port)
        {
            if (network_ == null)
                network_ = new Network();
            return network_.connect(ip, port);
        }

        private void Update()
        {

        }


        public void Open()
        {
            if (!connectToServer(loginIp_, loginPort_))
            {
                Debug.Log("로그인 서버 연결에 실패.");
            }
            network_.setPacketProcess(loginPacketProcess);
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
            while(true)
            {
                network_.receive();

                yield return null;
            }
        }

    }


}
