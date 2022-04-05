using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour
{
   
    public float speed = 0.1f; 
    public Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
      float xDirection = Input.GetAxis("Horizontal"); 
      float zDirection = Input.GetAxis("Vertical"); 

      Vector3 moveDirection = new Vector3(-xDirection, 0.0f, -zDirection); 

      transform.position += moveDirection * speed; 
      if(Input.GetButtonDown("Jump")) {
          //
          rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse); 

      }


    }

    void OnTriggerEnter ( Collider other) {
        if(other.gameObject.tag == "JumpScare") {
            SceneManager.LoadScene("JumpScare");
        }

    }
        
        
       

        

        
    

    


    
}
