using UnityEngine;
using System.Collections;

public class CreateMouse : MonoBehaviour
{

    bool isLocked;
    void Start()
    {
        setCursorLock(true);
    }

    void setCursorLock(bool isLocked)
    {

        this.isLocked = isLocked;
        Cursor.visible = !isLocked;
        if (isLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            //Time.timeScale = 1;

        }
        //If game IS paused
        else if (isLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
            //Time.timeScale = 0; 
        }
    }

        // Update is called once per frame
        void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            setCursorLock(!isLocked);
        }
    }
}