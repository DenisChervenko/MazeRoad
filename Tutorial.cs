using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject _tutorialScreen;
    private bool _firstTime;

    private int _temp;

    private void Start()
    {
        _temp = PlayerPrefs.GetInt("FirstTime");

        if(_temp == 1)
        {
            _tutorialScreen.SetActive(false);
        }
        else
        {
            _tutorialScreen.SetActive(true);
        }
    }

    public void OnClick()
    {
        _temp = 1;
        PlayerPrefs.SetInt("FirstTime", _temp);
        _tutorialScreen.SetActive(false);
    }
}
