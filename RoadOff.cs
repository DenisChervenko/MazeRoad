using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadOff : MonoBehaviour
{
    

    private Rigidbody _rb;
    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }  

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RoadOff"))
        {
            gameObject.SetActive(false);
        }
    }
}
