using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityGame
{
    public class Enter_btn : MonoBehaviour
    {
        public InputField ID;
        public InputField PW;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //tap해서 인풋필드 바꾸기~
            if (ID.isFocused && Input.GetKeyDown(KeyCode.Tab))
            {
                PW.ActivateInputField();
            }
            else if (PW.isFocused && Input.GetKeyDown(KeyCode.Tab))
            {
                ID.ActivateInputField();
            }

            //로그인 ㄲ
            if (Input.GetKeyDown(KeyCode.Return))
                btn_login();

        }

        public void btn_login()
        {
            //수정!!!
            //PK_C_REQ_ID_PW packet = new PK_C_REQ_ID_PW();
            //packet.id_ = ID.text;
            //packet.password_ = PW.text;

            PK_C_REQ_ENTER_GAME packet = new PK_C_REQ_ENTER_GAME();
            packet.name_ = ID.text;

            GameObject.Find("LoginNetWork").GetComponent<LoginNetWork>().sendPacket(packet);

        }

    }

}
