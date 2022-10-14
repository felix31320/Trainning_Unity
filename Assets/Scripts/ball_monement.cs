using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_monement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 100f;
    private Vector3 _forward = new Vector3(0,0,10);
    public string x;

   

    public int Point = 0;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("point"))
        {
            
            Debug.Log(" 1+ point");
        }
    }

    private void MovePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _rb.AddForce(transform.forward * _speed, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _rb.AddForce(transform.forward * -_speed, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _rb.AddForce(transform.right * _speed, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rb.AddForce(transform.right * -_speed, ForceMode.Force);
        }
    }
}
