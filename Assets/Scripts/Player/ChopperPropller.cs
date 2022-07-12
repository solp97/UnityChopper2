using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperPropller : MonoBehaviour
{
    public GameObject Propeller1;
    public GameObject Propeller2;
    public GameObject Chopper;
    private Rigidbody rigd;
    public float speed = 0f;
    public float fly = 0f;
    public float RotateSpeed = 0f;
    public bool EngineStart = false;

    float gravityScale = 9.8f;

    private void Start()
    {
        rigd = Chopper.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            EngineStart = !EngineStart;
        }

        if (Input.GetKey(KeyCode.W) && EngineStart)
        {
            speed += 0.03f;
            Propeller1.transform.Rotate(0f, speed, 0f);

            if (speed >= 16f)
            {
                speed = 16f;
            }
            else if (speed >= 15f)
            {
                fly += 0.1f * gravityScale;
                rigd.useGravity = false;

                rigd.velocity += new Vector3(0, fly * Time.deltaTime, 0);
            }
            else if (speed > 5f)
            {
                Propeller2.transform.Rotate(0f, speed - 5, 0f);
            }
        }
        else
        {
            speed -= 0.01f;
            Propeller1.transform.Rotate(0f, speed, 0f);
            Propeller2.transform.Rotate(0f, speed, 0f);
            if (speed <= 0f) speed = 0f;
            fly = 0f;
        }
        if (Input.GetKey(KeyCode.S) && EngineStart)
        {
            fly -= 0.5f;
            rigd.velocity += new Vector3(0, fly * Time.deltaTime, 0);
            rigd.useGravity = true;

        }
        if (Input.GetKey(KeyCode.A) && EngineStart)
        {
            RotateSpeed = -0.5f;
            Chopper.transform.Rotate(0f, RotateSpeed, 0f);
        }
        if (Input.GetKey(KeyCode.D) && EngineStart)
        {
            RotateSpeed = 0.5f;
            Chopper.transform.Rotate(0f, RotateSpeed, 0f);
        }
    }
}
