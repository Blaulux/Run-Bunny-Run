using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{
    public MotorCaminos motorCaminos;


    public void OnTriggerEnter2D (Collider2D collisionInfo){

        if (collisionInfo.gameObject.tag == "Limite"){
            Destroy(collisionInfo.transform.parent.gameObject);
            motorCaminos.CreateCaminos();
        }

    }
}
