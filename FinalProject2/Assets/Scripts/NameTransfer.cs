using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class NameTransfer : MonoBehaviour
{
    public TextMeshProUGUI username; 
    public InputField userinputfield; 

    public void setName(){
        username.text = "Welcome to Aqua Adventure!! " + userinputfield.text + " has been fishnapped by humans!!" + " Help them get home to their family. " + userinputfield.text + " is counting on you to bring them home safely...DONT GET EATEN!";

    }

    

    
}
