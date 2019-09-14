using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerAction : MonoBehaviour 
{
    //行動パターン
    //1:移動 2:攻撃 3:待機
    public int Type;
    public Vector3 Move;
    public PlayerAction(){
        Type = 1;
        Move = new Vector3();
    }
}