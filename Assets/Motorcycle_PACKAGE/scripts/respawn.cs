using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Rigidbody rb;
    Transform ts;
    public GameObject gameObjectts;
    Vector3 position;
    Vector3 offsetValue;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ts = GetComponent<Transform>();
        gameObjectts = gameObjectts.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        if(Input.GetKeyDown(KeyCode.T)){
            ts.position = offsetValue;
            }
    }

}
