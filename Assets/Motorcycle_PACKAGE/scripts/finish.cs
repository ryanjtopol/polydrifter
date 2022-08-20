using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public Transform finishText1;
    public Transform timeText;
    public Transform actualTimeText;
    public Text timeText2;
    public Text actualTimeText2;
    public Color gold;
    public Vector3 offsetValue;
    Transform finishTextTransform;
    Transform timeTextTransform;
    Transform actualTimeTransform;
    Vector3 position;
    public float offsetValueY;
    public TimeChange script;
    public Text stars;
    bool finished;
    public string map;
    AudioSource victory;
    // Start is called before the first frame update
    void Start()
    {
        finishTextTransform = finishText1.GetComponent<Transform>();
        timeTextTransform = timeText.GetComponent<Transform>();
        actualTimeTransform = actualTimeText.GetComponent<Transform>();
        position = transform.position;
        finished = false;
        victory = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        finishTextTransform.position = (timeText.position+actualTimeText.position) / 2  + offsetValue;
        if(finished == true){
            if(Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene(map);
            }  
        }
    }

    void OnTriggerEnter(Collider col){
        if(col.tag == "torus"){
            offsetValue.y = offsetValueY;
            script.hasFinished = true;
            timeText2.color = gold;
            actualTimeText2.color = gold;
            stars.color = gold;
            finished = true;
            victory.Play();
        }
    }

}
