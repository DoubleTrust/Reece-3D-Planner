using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour {

    public static bool MenuIsActive = false;
    public GameObject ViewMenuUI;
    public KeyCode CallMenu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(CallMenu))
        {
            if (MenuIsActive)
            {
                ViewMenuUI.SetActive(false);
                MenuIsActive = false;
            }
            else
            {
                ViewMenuUI.SetActive(true);
                MenuIsActive = true;
            }
        }
    }
}
