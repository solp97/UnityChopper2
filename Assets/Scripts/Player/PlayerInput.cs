using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool PlayerAlive { get; private set; }

    public float X { get; private set; }
    public float Y { get; private set; }
    void Update()
    {
        X = Y = 0f;
        PlayerAlive = true;

        if(PlayerAlive == true)
        {
            X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Vertical");
            /*Up = Input.GetKey(KeyCode.UpArrow);
            Down = Input.GetKey(KeyCode.DownArrow);
            Left = Input.GetKey(KeyCode.LeftArrow);
            Right = Input.GetKey(KeyCode.RightArrow);
            Space = Input.GetKeyUp(KeyCode.Space);*/
        }
    }
}
