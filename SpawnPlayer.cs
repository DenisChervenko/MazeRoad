using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private GameObject _playerPrefab;

    [SerializeField] private GameObject _disablerSpawnPointObject;

    static public bool _canSpawnPlayer = false;

    private void OnTriggerEnter(Collider other)
    {
        if(_canSpawnPlayer)
        {
            if(other.gameObject.CompareTag("Left") || other.gameObject.CompareTag("Right") || other.gameObject.CompareTag("Up"))
            {
                Vector3 spawnPoint = GetComponent<Collider>().gameObject.transform.position;

                _playerPrefab.transform.position = spawnPoint;

                _playerPrefab.SetActive(true);

                var obj = _disablerSpawnPointObject.GetComponent<DeleteSpawnPoint>();

                obj.DisableSpawnPoint();

                _canSpawnPlayer = false;
            }
        }        
    }
}
