using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelStore : MonoBehaviour
{
    public Image bgStore;
    public Image confirm;
    public Image notEnought;
    public Text totalCoins;
    public Text priceItem;
    //public Text stockItem;
    
    public GridLayoutGroup contenedorItems;

    [HideInInspector] public int convertTextPrice;
    [HideInInspector] public int convertTextStock;

    [HideInInspector] public int convertTextTotalCoins;

     public Button btnWhiteBunny;
     public Button btnUse;

     public Button btnQuit;
    
    public Button btnCloseStore;
    public user userScriptableObject;

    public ControladorBunny controladorBunnyScript;
    public GameObject wBunny;
    public GameObject Bunny;
    public GameObject activeBunnyG;
    public GameObject panelStore;

    public Countplay countPlayScript;

    //public GameObject nameWBunny;
    public SoundsController sounds;



   
    
    
    // Start is called before the first frame update
    void Start()
    {
         totalCoins.text = userScriptableObject.coins.ToString();
         convertTextTotalCoins = (int.Parse(totalCoins.GetComponent<Text>().text));  
         
//condición para validar si el btnUse está activado
         if(userScriptableObject.whiteBunny == true){
             btnWhiteBunny.interactable = false;
            //  btnUse.gameObject.SetActive(true);

             if(btnUse && wBunny.name == userScriptableObject.playingWith.name){
                 btnQuit.gameObject.SetActive(true);
                 
             }else{
                 btnUse.gameObject.SetActive(true);
             }

         }else{
             btnWhiteBunny.gameObject.SetActive(true);
         }

         setActiveBunny();
      
    }

    public void setActiveBunny(){
        
        activeBunnyG = userScriptableObject.playingWith;
       

        if(activeBunnyG){
            if (wBunny.name == activeBunnyG.name){
           
            Bunny.SetActive(false);
            wBunny.SetActive(true);
            controladorBunnyScript.Bunny = wBunny;
            countPlayScript.aniBunny = wBunny.GetComponent<Animator>();

           }else{
            Bunny.SetActive(true);
            wBunny.SetActive(false);
            controladorBunnyScript.Bunny = Bunny;
            countPlayScript.aniBunny = Bunny.GetComponent<Animator>();
           }

        }else{
            userScriptableObject.ActiveBBunny();
            Bunny.SetActive(true);
            wBunny.SetActive(false);
            controladorBunnyScript.Bunny = Bunny;
            countPlayScript.aniBunny = Bunny.GetComponent<Animator>();
        }      
    }

    public void ActiveStore(){
        bgStore.CrossFadeAlpha(1,0.3f,false);
        totalCoins.CrossFadeAlpha(1,0.3f,false);
        contenedorItems.gameObject.SetActive(true);
        btnCloseStore.gameObject.SetActive(true);
    }

    public void CloseStore(){
        sounds.ClickSound();
        //   btnCloseStore.gameObject.SetActive(false);

        //   bgStore.CrossFadeAlpha(0,0.3f,false);
        //   totalCoins.CrossFadeAlpha(0,0.3f,false);
        //   contenedorItems.gameObject.SetActive(false);   
        panelStore.SetActive(false);
   
    }


    public void clickBtn(){
        sounds.ClickSound();

            //convertTextStock = (int.Parse(stockItem.GetComponent<Text>().text));
            convertTextPrice = (int.Parse(priceItem.GetComponent<Text>().text));

                if(convertTextPrice <= convertTextTotalCoins){
                   confirm.gameObject.SetActive(true);

                }else{
                    notEnought.gameObject.SetActive(true);
                }           
    }

    public void ConfirmBuy(){

        convertTextPrice = (int.Parse(priceItem.GetComponent<Text>().text));
        userScriptableObject.coins = convertTextTotalCoins - convertTextPrice;
        totalCoins.text = userScriptableObject.coins.ToString();
        convertTextStock -=1;
      //  stockItem.text = convertTextStock.ToString();
        userScriptableObject.whiteBunny = true;
        btnUse.gameObject.SetActive(true);
        // btnWhiteBunny.interactable = false;
        confirm.gameObject.SetActive(false);
    }

    public void CloseConfirm(){
        sounds.ClickSound();
        confirm.gameObject.SetActive(false);
    }

    public void CloseNotEnought(){
        sounds.ClickSound();
        notEnought.gameObject.SetActive(false);
    }

    public void UseWhiteRabbit(){
        sounds.ClickSound();
        //Funciona
         wBunny.SetActive(true);
         Bunny.SetActive(false);
        controladorBunnyScript.Bunny = wBunny;
        userScriptableObject.ActiveWBunny();
        btnUse.gameObject.SetActive(false);
        btnQuit.gameObject.SetActive(true);
        //controladorBunnyScript.Bunny = userScriptableObject.playingWith;

    }

    public void Quitbtn(){
        sounds.ClickSound();
        Bunny.SetActive(true);
        wBunny.SetActive(false);
        controladorBunnyScript.Bunny = Bunny;
        userScriptableObject.ActiveBBunny();
        btnQuit.gameObject.SetActive(false);
        btnUse.gameObject.SetActive(true);

    }
}
