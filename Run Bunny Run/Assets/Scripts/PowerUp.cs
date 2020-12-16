using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public SoundsController sounds;
    public MotorCaminos motorCaminosScript;

   


    void OnTriggerEnter2D (Collider2D cInfo){

        if(cInfo.gameObject.tag == "Bunny"){
            sounds.carrotSoundPlay(); 
            gameObject.SetActive(false);  
            motorCaminosScript.speedCarrot();        
            
        }

    }
}
