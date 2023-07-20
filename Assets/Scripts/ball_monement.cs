using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_monement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 2f;
    private float _saute = 10f;
    private Vector3 _forward = new Vector3(0,0,10);
    public string x;
    public bool jump;
    public PauseMenu pause;

   

    public int Point = 0;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (pause.isPaused == false) { 
            MovePlayer();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("point"))
        {
            ScoreScript.Score ++;
            Debug.Log(" 1+ point");
        }

        if (collision.collider.CompareTag("Sol"))
        {
            jump = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Sol"))
        {
            jump = false;
        }
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _rb.AddForce(Vector3.forward * _speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector3.back * _speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector3.right * _speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _rb.AddForce(Vector3.left * _speed, ForceMode.Force);
        }

         
            if (Input.GetKey(KeyCode.Space) && jump == true)
            {
                _rb.AddForce(Vector3.up * _saute, ForceMode.Force);
            }
        
    }
}
