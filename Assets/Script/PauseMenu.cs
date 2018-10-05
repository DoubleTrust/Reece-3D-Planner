using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public KeyCode PressMenu;
	// Use this for initialization
	public void OnResume () {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

     void OnPause() 
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void OnReturnToMainmenu(int sceneIndex) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneIndex);

    }

    public void OnQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(PressMenu)) {
            if (GameIsPaused) { 
                OnResume();
            }
            else {
                OnPause();
            }
        }
	}
}
