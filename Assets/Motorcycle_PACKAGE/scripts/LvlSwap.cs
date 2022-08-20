using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSwap : MonoBehaviour
{
    public void swap(string level){
        SceneManager.LoadScene(level);
    } 
}
