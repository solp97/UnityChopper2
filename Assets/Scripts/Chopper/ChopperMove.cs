using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChopperMove : MonoBehaviour
{
    public float rotateSpeed= 0.00004f;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
        }
    }
}
