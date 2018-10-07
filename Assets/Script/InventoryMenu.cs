using UnityEngine;

public class InventoryMenu : MonoBehaviour {

    public static bool MenuIsActive = false;
    public GameObject InventoryMenuUI;
    public KeyCode CallMenu;
    bool isLocked;

    // Use this for initialization
    void Start () {
        setCursorLock(true);
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(CallMenu)) {

            setCursorLock(!isLocked);

            if (MenuIsActive)
            {
                InventoryMenuUI.SetActive(false);
                MenuIsActive = false;
            }
            else
            {
                InventoryMenuUI.SetActive(true);
                MenuIsActive = true;
            }
        }
	}

    void setCursorLock(bool isLocked)
    {

        this.isLocked = isLocked;
        Cursor.visible = !isLocked;
        if (isLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;

        }
        //If game is paused
        else if (isLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
