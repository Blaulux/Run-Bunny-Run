using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countplay : MonoBehaviour
{
    public GameObject motorCaminos;
    public GameObject numbers;

    public GameObject panelStore;
   
    public Sprite[] numbersIMG;

    public MotorCaminos motorCaminosScript;
  public Animator aniBunny;

  public SoundsController sounds;
  

    float wait =4;

    public bool stopCount=false;

    public bool startCount = false;
    public bool finishCount = false;
    // Start is called before the first frame update
    void Start()
    {
        //reproducir audio
        StartCount();
        //aniBunny = userScriptableObject.playingWith.GetComponent<Animator>();
       aniBunny.SetBool("Inicio",false);
    }

    public void StartCount(){

        if(startCount == true){
            panelStore.SetActive(false);
           // panelGO.SetActive(false);
            StartCoroutine(IEStartCount());
        }   
    }
    public  IEnumerator IEStartCount(){
         yield return new WaitForSeconds(1);

             InvokeRepeating("Counting",1.0f,1.0f);
    }

    void Counting(){
        wait--;

        if(wait >=3 ){
            numbers.GetComponent<SpriteRenderer>().sprite = numbersIMG[3];
            sounds.CountSoundPlay();
        }

        if(wait <=3 && wait >=2 ){
            numbers.GetComponent<SpriteRenderer>().sprite = numbersIMG[2];
            sounds.CountSoundPlay();

        }

        if (wait <=2 && wait >=1){
             numbers.GetComponent<SpriteRenderer>().sprite = numbersIMG[1];
             sounds.CountSoundPlay();

        }

        if(wait <=1 && finishCount == false){
            
            finishCount = true;
            motorCaminosScript.finishCountIMG = true;
            numbers.GetComponent<SpriteRenderer>().sprite = numbersIMG[0];
            sounds.MainTheme();
            
        }

        if (wait <=0 ){
            
            // sounds.MainTheme();
            //aniBunny.SetBool("Inicio", true);
            CancelInvoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( wait ==0 && stopCount ==false){
            stopCount = true;
            numbers.SetActive(false);
        }
        
    }
}
