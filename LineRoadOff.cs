using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRoadOff : MonoBehaviour
{ 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RoadOff"))
        {
            gameObject.SetActive(false);
        }
    }
}
