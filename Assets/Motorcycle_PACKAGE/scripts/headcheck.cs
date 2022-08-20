using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcheck : MonoBehaviour
{
    Vector3 position;
    public bool headhitCheck;
    public bool hashit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        headhitCheck =  Physics.Raycast(position,transform.up,3,1); 
        if(headhitCheck == true){
            hashit = true;
        }
        if(headhitCheck == false){
            hashit = false;
        }
    }
}
