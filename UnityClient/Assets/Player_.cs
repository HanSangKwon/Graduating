using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yuch_;


public class Player_ : MonoBehaviour {

    public GameObject Mal_1;
    public GameObject Mal_2;
    public GameObject Mal_3;
    public GameObject Mal_4;

    Dictionary<RerultYuch, int> Active = new Dictionary<RerultYuch, int>();


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }

    public void SetActive(RerultYuch rerultYuch)
    {
        Active.Add(rerultYuch, (int)rerultYuch);

    }


}
