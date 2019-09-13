using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // Start is called before the first frame update
    public static int MaxHP = 100;
    public int _HP = MaxHP;
    public int HP{
        get{ return _HP;}
        set{
            if(value == _HP)return;
            _HP = value;
            if(MaxHP < value){
                _HP = MaxHP;
            }
            
        }
    }
    public static int MaxMP = 100;
    public int _MP = MaxMP;
    public int MP{
        get{return _MP;}
        set{
            if(value == _MP)return;
            _MP = value;
            if(value > MaxMP)_MP=MaxMP;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMP(int mp){
        MP += mp;
    }
    public void ChangeHP(int hp){
        HP += hp;
    }
}
