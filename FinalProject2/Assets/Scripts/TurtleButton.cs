using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TurtleButton : MonoBehaviour
{
    public void turtle(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl1");
    }
}
