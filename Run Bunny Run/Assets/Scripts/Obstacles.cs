using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
   // public GameObject bunny;
    public GameObject motorCaminos;
    public MotorCaminos motorCaminosScript;
    // Start is called before the first frame update
    void Start()
    {
        motorCaminos = GameObject.Find("MotorCaminos");
        motorCaminosScript = motorCaminos.GetComponent<MotorCaminos>();
       // bunny = GameObject.Find("Bunny");
    }

    void OnCollisionEnter2D (Collision2D cInfo){

        if(cInfo.gameObject.tag == "Bunny"){
            motorCaminosScript.SpeedObstacle();

        }
    }

    void OnCollisionExit2D (Collision2D cExInfo){

        if (cExInfo.gameObject.tag == "Bunny"){
            motorCaminosScript.SpeedCaminos();
        }
    }

}
