using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false; 
    public GameObject pausemenuUI; 



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameisPaused) {
                Resume(); 
            } else {
                Pause(); 
            }
        }

        Resume(); 
        Pause(); 

    }

    void Resume() {
        pausemenuUI.SetActive(false); 
        Time.timeScale = 1f; 
        GameisPaused = false; 

    }

    void Pause() { 
        pausemenuUI.SetActive(true); 
        Time.timeScale = 0f; 
        GameisPaused = true;  


    }
}
