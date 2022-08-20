using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeChange : MonoBehaviour
{
    public Text time;
    public float number;
    public float numberRound;
    public bool hasFinished;
    public string map;
    public headcheck script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(hasFinished == false){ 
            if(number > 0){
                numberRound = number -= Time.deltaTime;
                numberRound = Mathf.Round(numberRound);
            }
        }
        if(number <= 0){
            number = 0 * Time.deltaTime;
            SceneManager.LoadScene(map);
        }    
        if(script.headhitCheck == true & hasFinished == false){
            time.text = "Press 'y' to restart          ";
        }
        else{
            time.text = numberRound.ToString();
        }
    }
}
