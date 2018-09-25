using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour {

    public Vector3 targetPoint = new Vector3(5, 0, 5);

    public void Itemmovement()
    {
        this.transform.position += new Vector3(targetPoint.x - this.transform.position.x, 0, 0);
        this.transform.position += new Vector3(0, 0, targetPoint.z - this.transform.position.z);
    }
}
