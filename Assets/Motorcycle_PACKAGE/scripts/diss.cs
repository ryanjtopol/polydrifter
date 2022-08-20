using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diss : MonoBehaviour
{
    public Text label;
    public headcheck script;
    public TimeChange finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.headhitCheck == true & finish.hasFinished == false){
            label.text = "";
        }
        else{
            label.text = "Time:";
        }
    }
}
