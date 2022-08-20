using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTextPosition : MonoBehaviour
{
    public Transform finishText;
    public Transform nextLevelTextPositionText;
    Vector3 position;
    public Vector3 offsetValue;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        nextLevelTextPositionText.position = finishText.position + offsetValue;
    }
}
