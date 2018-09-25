using UnityEngine;

public class InventoryMenu : MonoBehaviour {

    public static bool MenuIsActive = false;
    public GameObject InventoryMenuUI;
    public KeyCode CallMenu;

	// Use this for initialization
	void Start () {
		
	}


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(CallMenu)) {
            if (MenuIsActive)
            {
                InventoryMenuUI.SetActive(false);
                MenuIsActive = false;
            }
            else {
                InventoryMenuUI.SetActive(true);
                MenuIsActive = true;
            }
        }
	}
}
