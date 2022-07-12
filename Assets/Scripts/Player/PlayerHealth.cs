using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool isAlive;
    private void Start()
    {
        isAlive = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") Die();
/*
        if (null == other.GetComponent<Bullet>()) Die();*/
    }
    public void Die()
    {
        gameObject.SetActive(false);
        isAlive = false;
    }
}
