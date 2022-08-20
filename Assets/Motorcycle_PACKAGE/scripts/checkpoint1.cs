using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint1 : MonoBehaviour
{
    public AudioSource hit;
    public TimeChange script;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.tag == "torus"){
            script.number += 1250 * Time.deltaTime;
            Destroy(gameObject);
            hit.Play();
        }
    }
}
