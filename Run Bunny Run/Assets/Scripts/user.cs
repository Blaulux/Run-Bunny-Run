using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Datos", menuName = "ScriptableObjec/UserName")]

public class user : ScriptableObject
{
   // public InputField userInput;

    public string userName;
    public int coins;

    public bool whiteBunny;
    public bool Bunny= true;
     public GameObject wBunny;
    public GameObject BBunny;

    // public ControladorBunny controladorBunnyScript;

    public GameObject playingWith;


    public void getData(string data){
        userName = data;
    }

    public void CountCoins(int coinsData){
        coins = coins + coinsData ;
    }

    public void ActiveWBunny(){
        playingWith = wBunny;
    }

    public void ActiveBBunny(){
        playingWith = BBunny;

    }

    
    
}
