using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    bool inAir;
    public float speed;
    Rigidbody rb;
    float turn;
    float turnValue = -50;
    Vector3 position;
    Vector3 offset;
    public float maxSpeed;
    bool isforward = true;
    public bool groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        groundCheck =  Physics.Raycast(position,Vector3.down,3, 1);
        //transforms the motorcycle
        if(groundCheck == true){
        if(rb.velocity.z + rb.velocity.x < maxSpeed & rb.velocity.z + rb.velocity.x > -maxSpeed){
            if(rb.velocity.z < maxSpeed & rb.velocity.z > -maxSpeed){
                if(Input.GetKey(KeyCode.W)){ //forward
                    rb.AddRelativeForce(transform.forward*speed/4*Time.deltaTime);
                    if(Input.GetKey(KeyCode.D) == false & Input.GetKey(KeyCode.A) == false){
                        if(isforward == true){
                        if(rb.transform.eulerAngles.y > 270 & rb.transform.eulerAngles.y < 360){
                        rb.AddRelativeForce(transform.right*-speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y < 270 & rb.transform.eulerAngles.y > 180){
                        rb.AddRelativeForce(transform.right*speed/4*Time.deltaTime);
                        }
                        }   
                        if(isforward == false){
                        if(rb.transform.eulerAngles.y > 90 & rb.transform.eulerAngles.y < 180){
                        rb.AddRelativeForce(transform.right*-speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y < 90 & rb.transform.eulerAngles.y > 0){
                        rb.AddRelativeForce(transform.right*speed/4*Time.deltaTime);
                        }
                        }  
                    }
                }
                if(Input.GetKey(KeyCode.S)){ //backward
                rb.AddRelativeForce(transform.forward*-speed/4*Time.deltaTime);
                    if(Input.GetKey(KeyCode.D) == false & Input.GetKey(KeyCode.A) == false){
                        if(isforward == true){
                        if(rb.transform.eulerAngles.y > 90 & rb.transform.eulerAngles.y < 180){
                        rb.AddRelativeForce(transform.right*speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y < 90 & rb.transform.eulerAngles.y > 0){
                        rb.AddRelativeForce(transform.right*-speed/4*Time.deltaTime);
                        }
                        }
                        if(isforward == false){
                        if(rb.transform.eulerAngles.y < 270 & rb.transform.eulerAngles.y > 180){
                        rb.AddRelativeForce(transform.right*-speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y > 270 & rb.transform.eulerAngles.y < 360){
                        rb.AddRelativeForce(transform.right*speed/4*Time.deltaTime);
                        }
                        }   
                    }
                }

            }
            if(rb.velocity.x < maxSpeed & rb.velocity.x > -maxSpeed){
                if(Input.GetKey(KeyCode.D)){ //right
                rb.AddRelativeForce(transform.right*speed/4*Time.deltaTime);
                if(Input.GetKey(KeyCode.W) == false & Input.GetKey(KeyCode.S) == false){
                        if(isforward == true){
                        if(rb.transform.eulerAngles.y > 0 & rb.transform.eulerAngles.y < 90){
                        rb.AddRelativeForce(transform.forward*speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y < 360 & rb.transform.eulerAngles.y > 270){
                        rb.AddRelativeForce(transform.forward*-speed/4*Time.deltaTime);
                        }
                        }
                        if(isforward == false){   
                        if(rb.transform.eulerAngles.y < 180 & rb.transform.eulerAngles.y > 90){
                        rb.AddRelativeForce(transform.forward*-speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y > 180 & rb.transform.eulerAngles.y < 270){
                        rb.AddRelativeForce(transform.forward*speed/4*Time.deltaTime);
                        } 
                        }
                    }
                }
                if(Input.GetKey(KeyCode.A)){ //left
                rb.AddRelativeForce(transform.right*-speed/4*Time.deltaTime);
                if(Input.GetKey(KeyCode.W) == false & Input.GetKey(KeyCode.S) == false){
                        if(isforward == true){
                        if(rb.transform.eulerAngles.y > 180 & rb.transform.eulerAngles.y < 270){
                        rb.AddRelativeForce(transform.forward*-speed/4*Time.deltaTime);
                        }
                        }
                        if(rb.transform.eulerAngles.y < 180 & rb.transform.eulerAngles.y > 90){
                        rb.AddRelativeForce(transform.forward*speed/4*Time.deltaTime);
                        }
                        if(isforward == false){ 
                        if(rb.transform.eulerAngles.y < 360 & rb.transform.eulerAngles.y > 270){
                        rb.AddRelativeForce(transform.forward*speed/4*Time.deltaTime);
                        }
                        if(rb.transform.eulerAngles.y > 0 & rb.transform.eulerAngles.y < 90){
                        rb.AddRelativeForce(transform.forward*-speed/4*Time.deltaTime);
                        }
                        }  
                    }
                }
            }
        }
        } 
        //reverses turn and speed direction
        if(Input.GetKey(KeyCode.DownArrow)){
            if(speed > 0){
            turnValue = -turnValue;
            speed = -speed;
            isforward = false;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            if(speed < 0){
            turnValue = -turnValue;
            speed = -speed;
            isforward = true;
            }
        }
    }
 
}
