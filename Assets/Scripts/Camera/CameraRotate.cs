using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform Chopper;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Chopper);
    }
}
