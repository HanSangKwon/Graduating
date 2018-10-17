using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomManager : MonoBehaviour {



    List<User_> UserList = new List<User_>();
    public GameObject IndexPanel, textObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RegistUser(string text)
    {
        User_ newMessage = new User_();
        newMessage.text = text;

        GameObject newText = Instantiate(textObject, IndexPanel.transform);
        newMessage.textObject = newText.GetComponent<Text>();
        newMessage.textObject.text = newMessage.text;
        UserList.Add(newMessage);
    }

    public void DeleteUser(string text)
    {
        User_ Target = new User_();

        foreach(User_ chaild in UserList)
        {
            if(chaild.text == text)
            {
                Target = chaild;
            }
        }

        //삭제
        Destroy(UserList.Find( ) );
        UserList.Remove(Target);
    
    }


    [System.Serializable]
    public class User_
    {
        public string text;
        public Text textObject;
    }


}
