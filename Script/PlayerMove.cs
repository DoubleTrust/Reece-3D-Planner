using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10.0f;
     void Start()
    {
            
    }

    void Update() {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
        
    }
    /* CharacterController charControl;
     public float walkSpeed;

     void Awake()
     {
         charControl = GetComponent<CharacterController>();
     }

     void Update()
     {
         MovePlayer();
     }

     void MovePlayer()
     {
         float horiz = Input.GetAxis("Horizontal");
         float vert = Input.GetAxis("Vertical");

         Vector3 moveDirSide = transform.right * horiz * walkSpeed;
         Vector3 moveDirForward = transform.forward * vert * walkSpeed;

         charControl.SimpleMove(moveDirSide);
         charControl.SimpleMove(moveDirForward);
         

}*/

}
