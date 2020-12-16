using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject[] lifes;
    public int lifeCount =3;
    public GameObject panelGameO;
    public PanelGameOver gameOverScript;
    public GameObject motorCaminos;
    public MotorCaminos motorCaminosScript;
    public SoundsController sounds;

    void Update(){
                

        if (lifeCount == 2 && motorCaminosScript.gameOver ==false){
            lifes[2].SetActive(false);
            
        }

        if(lifeCount == 1 && motorCaminosScript.gameOver == false){
            lifes[1].SetActive(false);
           
        }

        if(lifeCount == 0 && motorCaminosScript.gameOver == false){
            lifes[0].SetActive(false);
            motorCaminosScript.gameOver= true;
            panelGameO.SetActive(true);
            gameOverScript.ActivePanel();
            sounds.MainThemeStop();
        }  
    } 
}
