using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedChange : MonoBehaviour
{
    public Transform torus;
    public GameObject torus1;
    Rigidbody torusrb;
    public Vector3 offsetValue;
    float velocityAdd;
    public float absoluteVelocity;
    
    public Text velocity;
    // Start is called before the first frame update
    void Start()
    {
        torusrb = torus1.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        velocityAdd = torusrb.velocity.z + torusrb.velocity.x;
        absoluteVelocity = Mathf.Abs(velocityAdd);
        absoluteVelocity = Mathf.Round(absoluteVelocity);
        velocity.text = absoluteVelocity.ToString();
        if(Input.GetKeyDown(KeyCode.R)){
            if(offsetValue.z > 0){
            offsetValue.z = -offsetValue.z;
            offsetValue.x = -offsetValue.x;
            }
        }
        if(Input.GetKeyDown(KeyCode.F)){
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
