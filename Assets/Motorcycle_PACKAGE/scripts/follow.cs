using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class follow : MonoBehaviour
{
    public Transform torus;
    public Vector3 offsetValue;
    public Vector3 rotationValue1;
    public Vector3 rotationValue2;
    public string map;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //reverses the position and rotation of the camera
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            if(offsetValue.z < 0){
            transform.eulerAngles = rotationValue1;
            offsetValue.z = -offsetValue.z;
            }
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(offsetValue.z > 0){
            transform.eulerAngles = rotationValue2;
            offsetValue.z = -offsetValue.z;
            }
        }
        //resets the map
        if(Input.GetKeyDown(KeyCode.Y)){
            SceneManager.LoadScene(map);
        //exits to the main menu
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("title");
        }
    }

    void LateUpdate(){
        //camera position follows the motorcycle
        transform.position = torus.position + offsetValue;
    }
}
