using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    public int PlayerType;
    public int HP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            this.transform.position += new Vector3(0,1,0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            this.transform.position += new Vector3(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            this.transform.position += new Vector3(0,-1,0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            this.transform.position += new Vector3(1,0,0);
        }
    }
}
