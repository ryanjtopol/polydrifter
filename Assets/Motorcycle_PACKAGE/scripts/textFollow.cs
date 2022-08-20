using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textFollow : MonoBehaviour
{
    public Transform torus;
    public Vector3 offsetValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            if(offsetValue.z > 0){
            offsetValue.z = -offsetValue.z;
            offsetValue.x = -offsetValue.x;
            }
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(offsetValue.z < 0){
            offsetValue.z = -offsetValue.z;
            offsetValue.x = -offsetValue.x;
            }
        }         
    }
    void LateUpdate(){
        transform.position = torus.position + offsetValue;
    }
}
