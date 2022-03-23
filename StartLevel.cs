using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] private float _timeBoostForStart;
    [SerializeField] private GameObject _parentCar;
    [SerializeField] private GameObject _startScreen;

    private bool _onceCall = false;
    private void Start()
    {
        _onceCall = false;

        Time.timeScale = _timeBoostForStart;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Road") || other.gameObject.CompareTag("LineRoad"))
        {
            Time.timeScale = 1;
            
                SpawnPlayer._canSpawnPlayer = true;

            if(!_onceCall)
            {
                var spawPoin = _parentCar.GetComponent<DeleteSpawnPoint>();

                spawPoin.EnableSpawnPoint();

                _startScreen.SetActive(true);

                Time.timeScale = 0;

                _onceCall = true;
            }

            var script = gameObject.GetComponent<StartLevel>();
        
            script.enabled = false;
        }
    }
}
