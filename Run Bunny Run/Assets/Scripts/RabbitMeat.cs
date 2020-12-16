using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMeat : MonoBehaviour
{
    public MotorCaminos motorCaminosScript;
    public SoundsController sounds;

    void OnTriggerEnter2D(Collider2D cInfo){

        if(cInfo.gameObject.tag == "Bunny"){
            
            gameObject.SetActive(false);
            sounds.meatSoundPlay();
            motorCaminosScript.SpeedRabbitMeat();
        }
    }
}
