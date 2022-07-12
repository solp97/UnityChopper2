using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightAndMornig : MonoBehaviour
{
    public GameObject Light;
    public float angle = 0.0004f;
    void Update()
    {
        Light.transform.Rotate(angle, 0f, 0f);
    }
}
