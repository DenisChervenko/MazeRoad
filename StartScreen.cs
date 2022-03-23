using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public void OnClick()
    {
        Time.timeScale = 1;

        gameObject.SetActive(false);
    }
}
