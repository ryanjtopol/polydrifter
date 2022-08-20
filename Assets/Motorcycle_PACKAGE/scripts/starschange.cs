using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starschange : MonoBehaviour
{
    public Text starsss;
    public TimeChange script;
    public int threetime;
    public int twotime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.numberRound >= threetime){
            starsss.text = "★  ★  ★";
        }
        else if(script.numberRound < threetime & script.numberRound >= twotime ){
            starsss.text = "★  ★  ☆";
        }
        else if(script.numberRound < twotime){
            starsss.text = "★  ☆  ☆";
        }
    }
}
