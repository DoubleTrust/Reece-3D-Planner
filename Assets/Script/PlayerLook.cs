using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
     public Transform playerBody;
     public float mouseSensitivity;

     float xAxisClamp = 0.0f;

     void Awake()
     {
         //Cursor.lockState = CursorLockMode.Locked;

     }

     void Update()
     {
         RotateCamera(); 

     }

     void RotateCamera()
     {
         float mouseX = Input.GetAxis("Mouse X");
         float mouseY = Input.GetAxis("Mouse Y");

         float rotAmountX = mouseX * mouseSensitivity;
         float rotAmountY = mouseY * mouseSensitivity;

         xAxisClamp -= rotAmountY;

         Vector3 targetRotCam = transform.rotation.eulerAngles;
         Vector3 targetRotBody = playerBody.rotation.eulerAngles;

         targetRotCam.x -= rotAmountY;
         targetRotCam.z = 0;
         targetRotBody.y += rotAmountX;

         if(xAxisClamp > 90)
         {
             xAxisClamp = 90;
             targetRotCam.x = 90;
         }
         else if(xAxisClamp < -90)
         {
             xAxisClamp = -90;
             targetRotCam.x = 270;
         }

         print(mouseY);


         transform.rotation = Quaternion.Euler(targetRotCam);
         playerBody.rotation = Quaternion.Euler(targetRotBody);


     }
    /*Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    GameObject character;

    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity*smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f,90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);

        
    }
    */


}
