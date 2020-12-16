using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCaminos : MonoBehaviour
{
    public GameObject motorCaminos;
    public GameObject[] contenedorCaminos;

    public float speed;
    public int numSelectorCaminos;
    public int countCaminos=0;

    public bool gameOver=false;
    public bool starGameBunny = false;
    public bool finishCountIMG;

    

    // Start is called before the first frame update
    void Start()
    {
       // gameOver = false;
        //starGameBunny = false;
        StartGame();
    }

    public void StartGame(){
        CreateCaminos();
        SpeedCaminos();
        finishCountIMG = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        if ( finishCountIMG && gameOver == false && starGameBunny == true){
            motorCaminos.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }


    }

    //Function to create a new road 
    public void CreateCaminos(){
        //Random number
        numSelectorCaminos = Random.Range(0,5);

        //New GameObject
        GameObject Road = (GameObject) Instantiate(contenedorCaminos[numSelectorCaminos], new Vector3 (0,50,0), transform.rotation);

        //Change Status
        Road.SetActive(true);
        //+1
        countCaminos++;
        //Pass the road name
        Road.name = "Camino" + countCaminos;
        //hierarchy
        Road.transform.parent = motorCaminos.transform;
        //-------Position the new road with the other------

        //Find the previous road
        GameObject Aux = GameObject.Find("Camino"+ (countCaminos -1));

        Road.transform.position = new Vector3(transform.position.x, Aux.GetComponent<Renderer>().bounds.size.y + Aux.transform.position.y, Aux.transform.position.z );

      //Debug.Log("Camino nuevo: " + Road.name + "Camino previo: " + Aux);
        

    }

    //speed changes according to the object it collides with

    //Normal Speed
    public void SpeedCaminos(){
        speed =6;

    }

    //Speed to stop
    public void SpeedStop(){
       speed=0;
    }

    //Speed if take rabbit meat 
    public void SpeedRabbitMeat(){
       speed = 3;
       StartCoroutine(NormalSpeed());
    }

    IEnumerator NormalSpeed(){
        yield return new WaitForSeconds(1);
        SpeedCaminos();

    }

    public void speedCarrot(){
        speed =8;
        StartCoroutine(BackSpeed());
    }

    IEnumerator BackSpeed(){
        yield return new WaitForSeconds(1);
        SpeedCaminos();
    }

    //Speed if you collides with a obstacle
    public void SpeedObstacle(){
        speed = 5;
    }

    public void FinishGame(){
        SpeedStop();
    }


}
