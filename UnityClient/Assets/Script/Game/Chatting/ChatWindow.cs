using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UnityGame
{

    public class ChatWindow : MonoBehaviour
    {
        //싱글톤~
        public static ChatWindow s_instance = null;
        public static ChatWindow Instance
        {
            get { return s_instance; }
        }

        //받았는지 체크!
        public bool ReciveFlag = false;
        //다른 유저의 아이디, 메세지.
        public string packet_name, packet_text;
        //내 아이디.
        private static string My_name;
        public void set_My_name(string name) { My_name = name; }

        public int countMessage = 25;
        public GameObject chatPanel, textObject;

        [SerializeField]
        List<Message> messageList = new List<Message>();
        public InputField IfText;

        void Awake()
        {
            //인스턴스된 싱글톤 클래스가 없다면 적용하기
            if (s_instance != null)
                Destroy(this.gameObject);
            s_instance = this;
            DontDestroyOnLoad(this);
            set_My_name(GameObject.Find("ChattingNetWork").GetComponent<ChattingNetWork>().NickName);
        }

        // Update is called once per frame
        void Update()
        {
            if (IfText.text != "")
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    btnSend();
                }
            }
            else
            {
                if (!IfText.isFocused && Input.GetKeyDown(KeyCode.Return))
                    IfText.ActivateInputField();
            }

            // 데이터 받으면, 받은내용 출력하기.
            if (ReciveFlag)
            {
                SendMessageToChat(packet_name + ": " + packet_text);
                ReciveFlag = false;
            }
        }

        public void btnSend()
        {
            PK_C_REQ_CHATTING packet = new PK_C_REQ_CHATTING();
            packet.text_ = IfText.text;
            GameObject.Find("ChattingNetWork").GetComponent<ChattingNetWork>().sendPacket(packet);
            SendMessageToChat(My_name + ": " + IfText.text);
            IfText.text = "";
        }

        public void SendMessageToChat(string text)
        {
            if (messageList.Count >= countMessage)
            {
                Destroy(messageList[0].textObject.gameObject);
                messageList.Remove(messageList[0]);
            }

            Message newMessage = new Message();
            newMessage.text = text;

            GameObject newText = Instantiate(textObject, chatPanel.transform);
            newMessage.textObject = newText.GetComponent<Text>();
            newMessage.textObject.text = newMessage.text;
            messageList.Add(newMessage);
        }


    }

    [System.Serializable]
    public class Message
    {
        public string text;
        public Text textObject;
    }

}