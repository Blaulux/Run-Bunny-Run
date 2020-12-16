using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fundido : MonoBehaviour
{
    public Image fundido;
    // Start is called before the first frame update
    void Start()
    {
        fundido.CrossFadeAlpha(0,0.5f,false);
    }

    
}
