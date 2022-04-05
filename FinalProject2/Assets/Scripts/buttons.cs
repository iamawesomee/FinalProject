using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public void start(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartingScreen");
    }

    public void restartt(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl2");
    }
}
