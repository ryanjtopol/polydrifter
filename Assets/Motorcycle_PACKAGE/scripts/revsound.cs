using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revsound : MonoBehaviour
{
    AudioSource rev;
    public speedChange script;
    // Start is called before the first frame update
    void Start()
    {
        rev = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.absoluteVelocity < 10){
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A)){
                rev.Play(0);
            } 
        }
    }
}
