using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightAndMornig : MonoBehaviour
{
    public GameObject Light;
    public float angle = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle += 0.0005f;
        Light.transform.Rotate(angle, 0f, 0f);
        if(angle >= 6f)
        {
            angle = 6f;
        }
    }
}
