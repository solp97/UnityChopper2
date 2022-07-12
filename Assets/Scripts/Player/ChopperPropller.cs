using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperPropller : MonoBehaviour
{
    public GameObject propeller1;
    public GameObject propeller2;
    public GameObject chopper;
    private Rigidbody rigd;
    public float speed = 0f;
    public float fly = 0f;
    public float rotateSpeed = 0f;
    public bool EngineStart = false;

    float gravityScale = 9.8f;

    private void Start()
    {
        rigd = chopper.GetComponent<Rigidbody>();
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
            propeller1.transform.Rotate(0f, speed, 0f);

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
                propeller2.transform.Rotate(0f, speed - 5, 0f);
            }
        }
        else
        {
            speed -= 0.01f;
            propeller1.transform.Rotate(0f, speed, 0f);
            propeller2.transform.Rotate(0f, speed, 0f);
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
            rotateSpeed = -0.5f;
            chopper.transform.Rotate(0f, rotateSpeed, 0f);
        }
        if (Input.GetKey(KeyCode.D) && EngineStart)
        {
            rotateSpeed = 0.5f;
            chopper.transform.Rotate(0f, rotateSpeed, 0f);
        }
    }
}
