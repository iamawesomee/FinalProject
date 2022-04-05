using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false; 
    [SerializeField] GameObject pauseMenu; 

    void Update () { 
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isGamePaused) {
                ResumeGame(); 
            }
            else { 
                PauseGame(); 
            }
        }
    }


    public void ResumeGame() { 
        pauseMenu.SetActive(false); 
        Time.timeScale = 1f; 
        isGamePaused = false; 


    }

    public void PauseGame() { 
        pauseMenu.SetActive(true); 
        Time.timeScale = 0f; 
        isGamePaused = true; 

    }
    public void LoadMenu(){ 
        SceneManager.LoadScene("StartingScreen"); 


    }
    public void Restart() { 
        SceneManager.LoadScene("Lvl1"); 
    }
   
   public void Question() { 
       SceneManager.LoadScene("help");
   }
   public void Meme(){ 
        SceneManager.LoadScene("meme");
   }

}
