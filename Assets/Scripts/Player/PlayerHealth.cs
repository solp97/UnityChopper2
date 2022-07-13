using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool isAlive;
    public bool isRide;
    public Gamemanager GameManager;
    private void Start()
    {
        isAlive = true;
        isRide = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") Die();
        // if (null == other.GetComponent<Bullet>()) Die();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Chopper" && Input.GetKey(KeyCode.F)) Ride();
    }
    public void Die()
    {
        gameObject.SetActive(false);
        isAlive = false;
        GameManager.End();
    }

    public void Ride()
    {
        gameObject.SetActive(false);
        isRide=true;
    }
}
