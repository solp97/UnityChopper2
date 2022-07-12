using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody _rb;
    public float speed = 5f;
    public bool UseSpeed = false;
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
        Debug.Log("PlayerMove");
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * speed;
        float ySpeed = _input.Y * speed;

        if (UseSpeed)
        {
            _rb.velocity  = new Vector3(xSpeed,0f,ySpeed);
        }
        else
        {

        _rb.AddForce(xSpeed,0f,ySpeed);

        }


/*
        if (_input.Down)
        {
            _rb.AddForce(0f, 0f, -speed);
        }

        if (_input.Left)
        {
            _rb.AddForce(-speed, 0f,0f);
        }

        if (_input.Right)
        {
            _rb.AddForce(speed, 0f, 0f);
        }

        if(_input.Space)
        {
            _rb.AddForce(0f, 15f, 0f,ForceMode.);
        }*/
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Chopper" && Input.GetKey(KeyCode.F))
        {
            this.gameObject.SetActive(false);
        }
    }
}
