using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerdata
{
    // Start is called before the first frame update
    public int levelname;
    public int n;
    public int coin ;
    
    public  playerdata(gamemanager gm){
        n     = gm.n ;
        levelname = gm.levelname;
        coin  = gm .coin;
    }

    
}
