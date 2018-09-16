using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yuch_;


public class GameManager_ : MonoBehaviour {

    Yuch yuch = new Yuch();
    RerultYuch rerultYuch;

    // Use this for initialization
    void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Throwing()
    {
        rerultYuch = yuch.ThrowYuch();
        Debug.Log(rerultYuch);


        GameObject.Find("Player_1").GetComponent<Player_>().SetActive(rerultYuch);
    }

}
