using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperPro : MonoBehaviour
{
    public GameObject Propeller;
    public GameObject Propeller2;
    public GameObject Chopper;
    public float speed = 0f;
    public float fly = 0f;
    public float RotateSpeed = 0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed += 0.03f;
            Propeller.transform.Rotate(0f, speed, 0f);
            if(speed > 5f)
            {
                Propeller2.transform.Rotate(0f, speed-5, 0f);
            }
            if(speed >= 15f)
            {
                speed = 15f;
                fly += 0.008f;

                    Chopper.transform.position = Chopper.transform.position + new Vector3(0, fly, 0);
            }
        }
        else
        {
            speed -= 0.01f;
            Propeller.transform.Rotate(0f, speed, 0f);
            Propeller2.transform.Rotate(0f, speed, 0f);
            if (speed <= 0f) speed = 0f;
            if (fly <= 0f) fly = 0f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            fly -= 0.0005f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            RotateSpeed = -0.5f;
            Chopper.transform.Rotate(0f, RotateSpeed, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotateSpeed = 0.5f;
            Chopper.transform.Rotate(0f, RotateSpeed,0f);
        }
    }
}
