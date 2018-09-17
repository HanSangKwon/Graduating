using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yuch_;


public class GameManager_ : MonoBehaviour {

    Yuch yuch = new Yuch();
    RerultYuch rerultYuch;

    public GameObject Player1;

    int sequence = 1;



    private void Update()
    {
        switch(sequence)
        {
            case 1:
                sequence = 2;
                break;
            case 2:
                sequence = 3;
                break;
            case 3:
                sequence = 4;
                break;
            case 4:
                sequence = 5;
                break;
            case 5:
                sequence = 6;
                break;

        }

    }

    public void P1_Throwing()
    {
        rerultYuch = yuch.ThrowYuch();
        Debug.Log("Player_1:" +  rerultYuch);
        GameObject.Find("Player_1").GetComponent<Player_>().SetActive(rerultYuch);  
    }


}
