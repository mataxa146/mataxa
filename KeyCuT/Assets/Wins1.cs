using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wins1 : MonoBehaviour {

	public GameObject Kensaku;
    public GameObject kensaku1;
    public GameObject canvas;

    
	void Update () {
        if (Input.GetKey(KeyCode.LeftControl)||Input.GetKey(KeyCode.RightControl)){
            if(Input.GetKeyDown(KeyCode.S)){
                Instantiate(Kensaku,new Vector2(0,0),Quaternion.identity);
                GameObject prefab =(GameObject)Instantiate(kensaku1,new Vector2(0,0),Quaternion.identity);
                prefab.transform.SetParent(canvas.transform,false);
            }
        }
    }

}