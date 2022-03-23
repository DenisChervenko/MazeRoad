using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUttonInGame : MonoBehaviour
{
    public void OnCLickRestart()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickToStartScreen()
    {
        SceneManager.LoadScene(0);
    }
}
