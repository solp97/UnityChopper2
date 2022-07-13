using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    private float timer;
    public Transform Target;
    public float RotateSpeed = 4f;
    public float randomNumber;
    public float randomMin = 1f;
    public float randomMax = 3f;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(randomMin, randomMax);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        transform.Rotate(0f, RotateSpeed, 0f);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            transform.LookAt(Target);
            if (timer >= randomNumber)
            {
                Instantiate(BulletPrefab,transform.position, transform.rotation);
                timer = 0;
                randomNumber = Random.Range(randomMin, randomMax);
            }
        }

    }
}