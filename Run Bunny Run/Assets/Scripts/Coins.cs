using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int coinCount; 
    public int coinValue;
    public Text CoinWin;
    public SoundsController sounds;


    void OnTriggerEnter2D (Collider2D cInfo){

        
         

        if(cInfo.gameObject.tag == "Bunny"){

            gameObject.SetActive(false);
            
             //Get the text value and sum the coin
             sounds.coinSoundPlay();
             coinValue = int.Parse(CoinWin.GetComponent<Text>().text);
             coinCount = coinValue +1;  
             CoinWin.text = coinCount.ToString();
        }
        
    }

   
}
