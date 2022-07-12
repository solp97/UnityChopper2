using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChopperMove : MonoBehaviour
{
    public float rotateSpeed= 0.04f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotateSpeed -= 0.1f;
            transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
        }
    }
}
