using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPosition : MonoBehaviour {

   public GameObject Position;






    private void OnMouseDown()
    {
        print("Click");
        Position.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0, 0);
    }

}
