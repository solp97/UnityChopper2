using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform Chopper;
    public Transform Player;
    PlayerHealth playerhealth;
    public bool getAlive;
    private void Start()
    {
        playerhealth = GetComponent<PlayerHealth>();
        if (playerhealth == null) return;
        getAlive = playerhealth.isAlive;
    }
    void Update()
    {
        transform.LookAt(getAlive ? Chopper : Player);
    }
}
