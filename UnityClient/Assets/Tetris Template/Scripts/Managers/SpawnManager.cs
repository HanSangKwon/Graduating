using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject[] shapeTypes;

    public void Spawn()
	{
		// Random Shape
   		 int i = Random.Range(0, shapeTypes.Length);

        //랜덤
		// Spawn Group at current Position
		GameObject temp =Instantiate(shapeTypes[0]) ;
        Managers.Game.currentShape = temp.GetComponent<TetrisShape>();
        temp.transform.parent = Managers.Game.blockHolder;
        Managers.Input.isActive = true;
    }
}
