using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    public int Synchro = 0;
    private string Sis;
    Vector3[] SisMove = new Vector3[2];

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
        if(TurnController.CheckTurn()==0){
            Sis = Input.inputString;
            SisMove[0] = new Vector3(x, y, 0);
        }
        if(TurnController.CheckTurn()==1){
            SisMove[1] = new Vector3(x, y, 0);
            int n = (Sis == Input.inputString)?1:-10;
            Players[0].SendMessage("ChangeMP",n);
            Players[1].SendMessage("ChangeMP",n);
            Players[0].transform.position += SisMove[0];
            Players[1].transform.position += SisMove[1];
        }
    }
}