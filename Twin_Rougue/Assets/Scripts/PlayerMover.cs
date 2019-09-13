using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    public int Synchro = 0;
    private string Sis;

    public GameObject[] Players = new GameObject[2];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            Move();
            TurnController.ChangeTurn();
        }
    }
    void Move(){
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Players[TurnController.CheckTurn()].transform.position += new Vector3(x,y,0);
        if(TurnController.CheckTurn()==0){Sis = Input.inputString;}
        if(TurnController.CheckTurn()==1){
            int n = (Sis == Input.inputString)?1:-10;
            Players[0].SendMessage("ChangeMP",n);
            Players[1].SendMessage("ChangeMP",n);
        }
    }
}
