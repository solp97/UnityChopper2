using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperLight : MonoBehaviour
{
    public GameObject ChopperLights;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            ChopperLights.SetActive(!ChopperLights.activeSelf);
        }
    }
}
