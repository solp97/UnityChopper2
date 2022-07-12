using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

        private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[OnCollisionEnter] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
         private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[OnCollisionStay] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[OnCollisionExit] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") Debug.Log("플레이어와 충돌");
        Debug.Log($"[OnTriggerEnter] Me : {gameObject.name}, Other : {other.gameObject.name}");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"[OnTriggerStay] Me : {gameObject.name}, Other : {other.gameObject.name}");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"[OnTriggerExit] Me : {gameObject.name}, Other : {other.gameObject.name}");
    }

    void Update()
    {
    }
}
