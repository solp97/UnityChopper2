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
                fly += 0.0008f;

                    Chopper.transform.position = Chopper.transform.position + new Vector3(0, fly, 0);
            }
        }
        else
        {
            speed -= 0.015f;
            fly -= 0.00001f;
            Propeller.transform.Rotate(0f, speed, 0f);
            Propeller2.transform.Rotate(0f, speed, 0f);
            if (speed <= 0f) speed = 0f;
            if (fly <= 0f) fly = 0f;
            Chopper.transform.position = Chopper.transform.position + new Vector3(0, fly, 0);
        }
    }
}
