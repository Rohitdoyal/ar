using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeperiod= 5f;
    public float animationtime= 2f; 

    public GameObject movetouch;
    public Text scoreText;
    public GameObject waterui;
    public GameObject fruitui;
    public GameObject fartiui;
    public GameObject cleanui;
    public GameObject menupanel;
    public GameObject soundui;

    GameObject[] gameObjectArray;
    private GameObject  apples ;
    public int coin =30;
    //Scene scene = SceneManager.GetActiveScene();
    public int levelname; //SceneManager.GetActiveScene().name;
    public int n; // count the no. of operation 
    // scoretext.text = coin.ToString("0");
    
    public void CompleteLevel(){
        Debug.Log("level  complete ");
        Invoke("nextlevel",timeperiod);
        
    }


     void nextlevel(){
        // levelname= levelname +1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        levelname = SceneManager.GetActiveScene().buildIndex;
        saveplayer();
    }
    
    private void Awake() {
        loadplayer();
        Debug.Log("name is "+ levelname);
       // if(levelname!=0){
        
        //SceneManager.LoadScene(levelname);
        //}
        
    }

    void Start()
    {   
        
        loadplayer();
        //levelname = SceneManager.GetActiveScene().name;
        Debug.Log("Active Scene is '" + levelname + "'.");
       // SceneManager.LoadScene(levelname);
        scoreText.text = "coins" + coin.ToString("0");
        gameObjectArray = GameObject.FindGameObjectsWithTag ("appletag");
        //Debug.Log("level name : "+ levelname);
        
    }


    void saveplayer(){
        savesystem.savedata(this);
    }

     void loadplayer(){
        playerdata data= savesystem.Loadplayer();
        levelname =  data.levelname;
        n    =       data.n;
        coin =       data.coin;

        // if (levelname == null)
        // {
        //     levelname = SceneManager.GetActiveScene().name;
          
        // }
        // SceneManager.LoadScene(levelname);
    


    }
    public void endgame(){
        saveplayer();
        Debug.Log("quit");
        Application.Quit();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

  

    
    public void waterbutton(){
    if(coin > 0){
    n++;
    Debug.Log("Button clicked " + n + " times.");
    coin = coin-5;
    scoreText.text = "coins" + coin.ToString("0");
    
    // waterui.SetActive(true);
    Invoke("enwateruI",animationtime);
    // if (n==2 || n==4)
    // {   
    //     Debug.Log(" enable ---->apple tag ");
    //     Invoke("enapple",animationtime);
    // }
   

    if(n>=5){

        Invoke("nextlevel",timeperiod);
        n=0;

    }}
    else
    {
        Debug.Log("coin not sufficient");
    }
    }


    public void fratilibutton(){
        if(coin >= 5){
        coin = coin-5;
        scoreText.text = "coins" +coin.ToString("0");
        Debug.Log("fratilisation complete ");
        Invoke("enfratiuI",animationtime);}

        else
        {
            Debug.Log("coin not sufficient");
        }

    }
    public void fruitbutton(){
        coin = coin+10;
        scoreText.text = "coins" + coin.ToString("0");
        Debug.Log("fruit collected");
        Invoke("enfruituI",animationtime);
        //apple private void OnDisable() {
        Invoke("disapple",animationtime);
    }

    public void cleanbutton(){
        if(coin >= 5){
        coin = coin-5;
        scoreText.text = "coins" + coin.ToString("0");
        Debug.Log("cleaness complete ");
        Invoke("encleanuI",animationtime);}

        else
        {
            Debug.Log("coin not sufficient");
        }


    }

    


    void enwateruI(){
         waterui.SetActive(true);
         Invoke("disablewateruI",animationtime);
    }
    void disablewateruI(){
         waterui.SetActive(false);
    }


    void enfruituI(){
         fruitui.SetActive(true);
         Invoke("disablefruitruI",animationtime);
    }
    void disablefruitruI(){
        fruitui.SetActive(false);
        //apples.SetActive(false);
    }

    void encleanuI(){
         cleanui.SetActive(true);
         Invoke("disablecleanuI",animationtime);
    }
    void disablecleanuI(){
         cleanui.SetActive(false);
    }

    void enfratiuI(){
         fartiui.SetActive(true);
         Invoke("disablefratiuI",animationtime);
    }
    void disablefratiuI(){
         fartiui.SetActive(false);
    }


//    void apple(tag a){
//        a.tag.SetActive(false);
//    } 


    void disapple()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("appletag");
 
        foreach(GameObject go in gameObjectArray)
        {
            go.SetActive (false);
        }
    }
    
    void enapple()
    {   
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("appletag");
        foreach (GameObject go in gameObjectArray)
                {
                    go.SetActive(true);
                 
                }
    }

    public void menuubar(){
        Debug.Log(" Menu bar open ");
        menupanel.SetActive(true);
    } 
    public void continuew(){
        menupanel.SetActive(false);
    }
    public void sound(){
        Debug.Log("sound ka option");
        soundui.SetActive(true);
    }
    public void back(){
        Debug.Log("sound ka option ");
        soundui.SetActive(false);
    }



}
