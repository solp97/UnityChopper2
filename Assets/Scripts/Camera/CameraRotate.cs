using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform Chopper;
    void Update()
    {
        transform.LookAt(Chopper);
    }
}
