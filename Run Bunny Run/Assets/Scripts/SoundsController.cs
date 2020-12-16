using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    public AudioSource[] soundsList;

    public void MainTheme(){
        soundsList[0].Play();
    }

    public void MainThemeStop(){
        soundsList[0].Stop();
    }
    public void meatSoundPlay(){
       soundsList[1].Play();
   }
   
   public void coinSoundPlay(){
       soundsList[2].Play();
   }

   

   public void trapSoundPlay(){
       soundsList[3].Play();
   }

   public void carrotSoundPlay(){
       soundsList[4].Play();
   }

   public void GameOverSoundPlay(){
       soundsList[5].Play();
   }

   public void GameOverStop(){
       soundsList[5].Stop();
   }

   public void CountSoundPlay(){
       soundsList[6].Play();
   }

   public void ClickSound(){
       soundsList[7].Play();
   }
}
