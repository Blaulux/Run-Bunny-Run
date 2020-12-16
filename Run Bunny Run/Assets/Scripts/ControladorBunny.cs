using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBunny : MonoBehaviour
{
   
    public float velocityBunny;

    public float turningAngle;
    public bool startGameB = false;

    public user userScriptableObject;
    [HideInInspector] public GameObject Bunny;
     public Animator aniBunny;

    void Start(){
        // startGameB = false;
    }
    

    void FixedUpdate(){
       aniBunny = Bunny.GetComponent<Animator>();
       
        float turnZ = 0;

        if (startGameB == true){
           aniBunny.SetBool("Inicio", true);
           transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * velocityBunny * Time.deltaTime);  
           turnZ = Input.GetAxis("Horizontal") * -turningAngle;

        }else{
            aniBunny.SetBool("Inicio",false);
        }
        
        //Bunny.transform.rotation = Quaternion.Euler(0,0,turnZ);

        // if (Bunny.transform.position.y < -3.47f || Bunny.transform.position.x < -10.34f || Bunny.transform.position.x > 9.63f){
        //     ResetPosition();
        // }

        if (Bunny.transform.position.y < -3.47f ){
             ResetPosition();
         }

    }

    void ResetPosition(){
        Bunny.transform.position = new Vector3(0f,-3.47f,0f);
    }
}
