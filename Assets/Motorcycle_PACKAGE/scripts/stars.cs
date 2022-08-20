using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stars : MonoBehaviour
{
    public Vector3 offsetValue;
    public Transform timeText;
    public Transform actualTimeText;
    public Transform star;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        star.position = (timeText.position+actualTimeText.position) / 2  + offsetValue;
    }
}
