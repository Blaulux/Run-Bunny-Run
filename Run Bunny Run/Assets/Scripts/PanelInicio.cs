using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInicio : MonoBehaviour
{

    public Button btnAyudita;
    public Button btnTiendita;
    public Button btnPlay;

    public Text welcome;

    public Image bgUser;
    public Image bgInicio;
    public Image bunnytoIMG;

    public InputField userName;

    public user userScriptableObject;

    public GameObject panelInicio;
    public GameObject panelAyuda;
    public GameObject storePanel;

    public MotorCaminos motorCaminosScript;
    public ControladorBunny bunnyScript;
    public PanelStore storePanelScript;
    public Countplay countPlayScript;

    public SoundsController sounds;


    // Start is called before the first frame update
    void Start()
    {
        
        storePanelScript.setActiveBunny();
        
        if(userScriptableObject.userName == "" ){
            welcome.text = "Welcome ";      
        }else{   
            welcome.text = "Welcome " + userScriptableObject.userName;
        }  

        
    }

    public void PlayGame(){
        sounds.ClickSound();

        if(userScriptableObject.userName == "" ){
            bgUser.gameObject.SetActive(true);
            btnPlay.gameObject.SetActive(false);
        }else{  
            closePanel();
        }
    }

    public void GetSetData(){
        sounds.ClickSound();
        userScriptableObject.getData(userName.text);
        welcome.text = "Welcome " + userScriptableObject.userName;
        bgUser.gameObject.SetActive(false);
        btnPlay.gameObject.SetActive(true);
    }

    public void closePanel(){   
           
          btnAyudita.gameObject.SetActive(false);
          btnTiendita.gameObject.SetActive(false);
          btnPlay.gameObject.SetActive(false);
          welcome.CrossFadeAlpha(0,0.3f,false);
          bunnytoIMG.CrossFadeAlpha(0,0.3f,false);
          bgInicio.CrossFadeAlpha(0,0.3f, false);
          welcome.CrossFadeAlpha(0,0.3f,false);
          motorCaminosScript.starGameBunny = true;
          bunnyScript.startGameB = true;
          
          countPlayScript.startCount= true; 
          countPlayScript.StartCount(); 
    }

    public void ActivePanelInicio(){
         btnPlay.gameObject.SetActive(false);
        
    }

    public void ActivePanelAyuda(){
        sounds.ClickSound();
      panelAyuda.gameObject.SetActive(true);

    }

    public void ActiveStorePanel(){
        sounds.ClickSound();
        storePanel.gameObject.SetActive(true);
        storePanelScript.ActiveStore();
    }


}
