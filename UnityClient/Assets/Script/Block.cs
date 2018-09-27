using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {


    float fall = 0;
    public float fallSpeed = 1;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        UserInput();


    }
    void UserInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 90);

        }
        else if (Input.GetKey(KeyCode.DownArrow) || Time.time - fall >= fallSpeed)
        {
            transform.position += new Vector3(0, -1, 0);

            fall = Time.time;

        }

        if (Input.GetKey(KeyCode.Space))
            transform.Rotate(0, 0, 90);



    }

}
