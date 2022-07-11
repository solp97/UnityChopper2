using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperLight : MonoBehaviour
{
    public GameObject ChopperLights;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            ChopperLights.SetActive(!ChopperLights.activeSelf);
        }
    }
}
