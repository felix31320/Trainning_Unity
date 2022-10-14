using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Train : MonoBehaviour
{
    public GameObject[] lumiere;
    private void Start()
    {
        for (int i = 0; i < lumiere.Length; i++)
        {
            lumiere[i].SetActive(false);
        }
    }



}
