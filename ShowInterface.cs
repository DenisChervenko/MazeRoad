using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInterface : MonoBehaviour
{
    [SerializeField] private GameObject[] _interfaceMenu;

    private void Start()
    {
        for(int i = 0; i <= (_interfaceMenu.Length - 1); i++)
        {
            _interfaceMenu[i].SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for(int i = 0; i <= (_interfaceMenu.Length - 1); i++)
        {
            _interfaceMenu[i].SetActive(true);
        }

        var script = gameObject.GetComponent<ShowInterface>();

        Destroy(script);
    }
}
