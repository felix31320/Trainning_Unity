using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Point : MonoBehaviour
{
   
    public GameObject Cube1;
    
   
    void Update()
    {
        Cube1.transform.Rotate(0, 100*Time.deltaTime, 0, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(Cube1);
            Debug.Log("touche");
        }
    }
}
