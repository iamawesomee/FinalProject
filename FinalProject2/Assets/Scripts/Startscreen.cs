using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Startscreen : MonoBehaviour
{
    public void start(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Rules");
    }

    public void URL(){
        Application.OpenURL("https://youtu.be/0tkLUap7oGQ");
    }
}
