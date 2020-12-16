using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAyuda : MonoBehaviour
{
    public Image Background;
    public Image imagen;
    public Button backButton;

    public GameObject panelAyudaa;


    public void ClosePanel(){
        // Background.CrossFadeAlpha(0,0.3f,false);
        // imagen.CrossFadeAlpha(0,0.3f,false);
        // backButton.gameObject.SetActive(false);
        panelAyudaa.SetActive(false);

    }
    
}
