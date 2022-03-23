using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private TMP_Text _level;
    private int _levelIndex;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Level"))
        {
            _levelIndex = PlayerPrefs.GetInt("Level");
            _level.text = Convert.ToString(PlayerPrefs.GetInt("Level"));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            _levelIndex++;

            PlayerPrefs.SetInt("Level", _levelIndex);

            SceneManager.LoadScene(1);
        }
    }
}
