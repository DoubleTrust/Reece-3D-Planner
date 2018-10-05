using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMouse : MonoBehaviour {
    float rotSpeed = 700;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseOver () {
        if (Input.GetMouseButton(1))
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.down, rotY);
        }
    }
}
