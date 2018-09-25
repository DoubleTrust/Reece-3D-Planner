using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Onstart : MonoBehaviour
{

    // Use this for initialization
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
}
