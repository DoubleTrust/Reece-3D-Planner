using UnityEngine;
using System.Collections;

public class Drag1 : MonoBehaviour
{
    Vector3 dist;
    float posX;
    float posY;
    Rigidbody rbody;
    /*public Camera cam;
    public Transform sphere;
    public float distanceFromCamara;

    void start()
    {
        distanceFromCamara = Vector3.Distance(sphere.position,cam.transform.position);
        r = sphere.GetComponent<Rigidbody>();
    }

    Vector3 lastPos;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = sphere.position.z;
            pos = cam.ScreenToViewportPoint(pos);
            sphere.position = pos;
        }
    }
    Vector3 dist;
    float posX;
    float posY;

    private Rigidbody rbody;*/

    void start()
    {
        rbody = GetComponent<Rigidbody>();
    }


    void OnMouseDown()
    {
        Cursor.visible = true;
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

    }
    void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;

    }
}
