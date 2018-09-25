using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraevent : MonoBehaviour {

    public Camera[] cams;
    public void camMainMove()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
    }
    public void camOneMove()
    {
        cams[1].enabled = true;
        cams[0].enabled = false;
    }
}
