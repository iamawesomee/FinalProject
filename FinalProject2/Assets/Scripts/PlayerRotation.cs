using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
   public float rotaionSpeed = 1f; 

   void OnMouseDrag(){ 
       float XaxisRotation = Input.GetAxis("Mouse X") * rotaionSpeed;
       float YaxisRotation = Input.GetAxis("Mouse Y") * rotaionSpeed; 

       transform.Rotate(Vector3.down, XaxisRotation);
       transform.Rotate(Vector3.right, YaxisRotation);
   }

   void Update(){
       OnMouseDrag();
   }
}
