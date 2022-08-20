using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contigousrev : MonoBehaviour
{
    AudioSource rev;
    public speedChange script;
    bool isDriving = false;
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
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)){
            if(rev.pitch < 1.3){
                rev.pitch += .1f * Time.deltaTime;
                isDriving = true;
            if(rev.volume < .325f){
                rev.volume += .1f * Time.deltaTime;
            }
            }
        }
        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)){
                isDriving = false;
            } 
        if(isDriving == false){
            if(rev.pitch > .77){
                rev.pitch -= .1f * Time.deltaTime;
                rev.volume -= .1f * Time.deltaTime;
            }
        } 
    }
}
