using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    Rigidbody rb;
    public int jumpspeed;
    public movement script;
    bool gc;
    Vector3 position;
    bool firstj;

    // Start is called before the first frame update
    void Start()
    {
        firstj = false;
        position = transform.position;
        rb = GetComponent<Rigidbody>();
        gc = Physics.Raycast(position,Vector3.down,3,1);
    }

    // Update is called once per frame
    void Update()
    {   
        if(firstj == true){
            if(script.groundCheck == true){
                if(Input.GetKeyDown(KeyCode.Space)){
                    rb.AddForce(Vector3.up*jumpspeed*Time.fixedDeltaTime);
                }    
            }
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)){
            firstj = true;  
        }
    }
}
