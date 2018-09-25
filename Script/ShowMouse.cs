using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
            Cursor.visible = false;
        if (Input.GetKeyDown(KeyCode.Z))
            Cursor.visible = true;
    }
}
