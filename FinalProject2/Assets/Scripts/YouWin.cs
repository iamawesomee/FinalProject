using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class YouWin : MonoBehaviour
{
    void OnTriggerEnter ( Collider other) {
     SceneManager.LoadScene(6); 

    }
}

