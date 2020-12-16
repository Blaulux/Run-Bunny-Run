using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelGameOver : MonoBehaviour
{
    public Image background;
    public Image imagen;
    public Image fundido;
    public Button btnAgain;
    public Button btnHome;
    public Text coins;

    public GameObject panelGameO;

    public Text coinWin;

    public ControladorBunny bunnyScript;

    // public MotorCaminos motorCaminosScript;
    public Countplay countPlayScript;

    public user userScriptableObject;

    public PanelStore storePanelScript;
    public SoundsController sounds;
    

    void Start(){
        panelGameO.SetActive(false);
        
    }

//Function to active GameOver panel
    public void ActivePanel(){
        sounds.GameOverSoundPlay();
        bunnyScript.startGameB = false;
        btnAgain.gameObject.SetActive(true);
        btnHome.gameObject.SetActive(true);
        background.CrossFadeAlpha(1,0.3f,false);
        imagen.CrossFadeAlpha(1,0.3f,false);
        coins.CrossFadeAlpha(1,0.3f,false);
        coins.text = "Coins: " + (int.Parse(coinWin.GetComponent<Text>().text));
        userScriptableObject.CountCoins((int.Parse(coinWin.GetComponent<Text>().text)));
    }

    public void reset(){
        sounds.ClickSound();
        sounds.GameOverStop();
        
        //enviar los datos necesarios para reproducción
          storePanelScript.setActiveBunny();         
          fundido.CrossFadeAlpha(1,0.5f, false);

          StartCoroutine(PlayAgainScene()); 
    }

    IEnumerator PlayAgainScene(){
        yield return new WaitForSeconds(1);
           
           countPlayScript.StartCount();
        SceneManager.LoadScene("PlayAgain");
    }

    public void BackHome(){
        sounds.ClickSound();
        sounds.GameOverStop();
        fundido.CrossFadeAlpha(1,0.5f, false);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene(){
        yield return new WaitForSeconds(1);

        //SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        SceneManager.LoadScene("SampleScene");


    }


    
}
