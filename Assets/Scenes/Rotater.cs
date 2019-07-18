using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform:나 자신의 transform으로 바로 들어감(short cut)
    }

    // Update is called once per frame
    void Update()
    {
        float frequency = 60 * Time.deltaTime;
        transform.Rotate(frequency, frequency, frequency);
    }
}
