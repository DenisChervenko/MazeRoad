using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    private int _balancePlayer;

    private int _coinTemp;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Coin"))
        {
            _balancePlayer = PlayerPrefs.GetInt("Coin");
        }
    }
}
