using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{   

    public int levelname;
    // Start is called before the first frame update
    void Start()
    {
        playerdata data= savesystem.Loadplayer();
        if (data==null)
        {
            levelname=1;
            Debug.Log(" level start hua inside start nulladata set  "+levelname);
        }
        else{
        levelname =  data.levelname;
        Debug.Log(" level start hua inside start  "+levelname);
        }
        if (levelname==0)
        {
            levelname=levelname+1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play(){
       // levelname=gm.levelname;
        SceneManager.LoadScene(levelname);
        Debug.Log(" level start hua "+levelname);
    }
}
