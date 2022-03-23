using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPointForDisabled;

    public void Start()
    {
        for(int i = 0; i <= (_spawnPointForDisabled.Length - 1); i++)
        {
            _spawnPointForDisabled[i].SetActive(false);
        }
    }

    public void EnableSpawnPoint()
    {
        for(int i = 0; i <= (_spawnPointForDisabled.Length - 1); i++)
        {
            _spawnPointForDisabled[i].SetActive(true);
        }
    }

    public void DisableSpawnPoint()
    {
        for(int i = 0; i <= (_spawnPointForDisabled.Length - 1); i++)
        {
            _spawnPointForDisabled[i].SetActive(false);
        }
    }
}
