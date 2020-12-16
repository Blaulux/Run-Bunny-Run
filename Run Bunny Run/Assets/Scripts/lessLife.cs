using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessLife : MonoBehaviour
{
    public GameObject lifes;
    public Vidas lifeScript;
    public int totallifes;
    public SoundsController sounds;

    // Start is called before the first frame update
    void Start()
    {
        lifes = GameObject.Find("Vidas");
        lifeScript = lifes.GetComponent<Vidas>();
    }

    void OnTriggerEnter2D (Collider2D cInfo){

        if(cInfo.gameObject.tag == "Bunny"){
            
            sounds.trapSoundPlay();
            lifeScript.lifeCount = lifeScript.lifeCount -1;
            gameObject.SetActive(false);
        }
    }

}
