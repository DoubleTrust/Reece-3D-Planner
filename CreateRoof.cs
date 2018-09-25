using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoof : MonoBehaviour {

    public GameObject roof;

    public void Enable()
    {
        roof.SetActive(true);
    }

    public void Disable()
    {
        roof.SetActive(false);
    }
}
