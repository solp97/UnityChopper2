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
    public float nowAngle;
    public float maxAngle;
    public float minAngle;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(randomMin, randomMax);
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Quaternion.Angle(transform.rotation, Target.rotation);
        timer += Time.deltaTime;
        //transform.Rotate(0f, RotateSpeed, 0f);

        Vector3 distanceVector = Target.position - transform.position;
        nowAngle = Mathf.Atan2(distanceVector.x, distanceVector.z) * Mathf.Rad2Deg;
        Debug.Log(Vector3.Dot(transform.forward, distanceVector.normalized));
        Debug.Log($"Áö±Ý °¢{nowAngle}");
        Debug.DrawRay(transform.position, transform.forward * 5, Color.magenta);
        Debug.DrawRay(transform.position, distanceVector, Color.red);
    }
    private void OnTriggerStay(Collider other)
    {
        Vector3 distanceVector = Target.position - transform.position;
        if (other.gameObject.tag =="Player" && nowAngle >= maxAngle && nowAngle <= minAngle )
        {
            transform.LookAt(Target);
            fire();
        }

    }

    private void fire()
    {
        if (timer >= randomNumber)
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);
            timer = 0;
            randomNumber = Random.Range(randomMin, randomMax);
        }
    }
}
