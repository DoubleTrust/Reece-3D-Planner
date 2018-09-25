using UnityEngine;

public class TimeController : MonoBehaviour {
    private bool CameraFrozen = false;

    void Update() {
        // If inventory menu or view controller menu is open
        if ((InventoryMenu.MenuIsActive == true || ViewController.MenuIsActive == true || PauseMenu.GameIsPaused == true) && CameraFrozen == false)
        {
            (GetComponent("FirstPersonController") as MonoBehaviour).enabled = false;
            CameraFrozen = true;
        }
        //if they are all closed
        else
        {
            (GetComponent("FirstPersonController") as MonoBehaviour).enabled = true;
            CameraFrozen = false;
        }   
    }

}
