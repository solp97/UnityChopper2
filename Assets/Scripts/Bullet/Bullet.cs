using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed= 0.1f;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        transform.Translate(0f, 0f, BulletSpeed);
    }


}
