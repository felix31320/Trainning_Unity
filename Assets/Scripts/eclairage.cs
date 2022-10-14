using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eclairage : MonoBehaviour
{
    public Light lumiere;
    
    void Start()
    {
        lumiere = GetComponent<Light>();
        //lumiere.GetComponent<Light>().enabled = false;
    }

    private void Update()
    {
        
    }
}
