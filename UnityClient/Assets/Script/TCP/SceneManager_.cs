using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace UnityGame
{
    //씬이 많아지면 사용하자.
    public enum Scene_Index
    {
        LOGIN,
        RUN
    }

    public class SceneManager_: MonoBehaviour
    {
        //싱글톤~
        public static SceneManager_ s_instance = null;
        public static SceneManager_ Instance
        {
            get { return s_instance; }
        }

        void Awake(){
            //인스턴스된 싱글톤 클래스가 없다면 적용하기
            if (s_instance != null)
                Destroy(this.gameObject);
            s_instance = this;
            DontDestroyOnLoad(this);

            Screen.SetResolution(800, 600, false);

        }


        public void changeScene( Scene_Index sN ){
            //조건문 삭제 예정!!
            if(SceneManager.GetActiveScene().buildIndex != 1)
            SceneManager.LoadScene((int) sN);
        }

    }
}
