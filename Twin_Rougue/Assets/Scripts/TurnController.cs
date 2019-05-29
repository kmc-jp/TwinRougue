using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Turn=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static int CheckTurn(){
        return Turn;
    }
    public static void ChangeTurn(){
        Turn++;
        Turn%=2;
        //Debug.Log(Turn);
    }

    
}
