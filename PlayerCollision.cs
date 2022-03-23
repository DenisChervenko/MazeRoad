using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameObject _dieScreen;

    private bool _inTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Up"))
        {
            _inTrigger = true;

            PlayerControl._canClick = true;
            PlayerControl._direction = 0;
        }
        else if(other.gameObject.CompareTag("Left"))
        {
            _inTrigger = true;

            PlayerControl._canClick = true;
            PlayerControl._direction = 1;
        }
        else if(other.gameObject.CompareTag("Right"))
        {
            _inTrigger = true;

            PlayerControl._canClick = true;
            PlayerControl._direction = 2;
        }

        if(other.gameObject.CompareTag("Die"))
        {
            _dieScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!_inTrigger)
        {
            if(other.gameObject.CompareTag("Up") || other.gameObject.CompareTag("Left") 
            || other.gameObject.CompareTag("Right"))
            {
                PlayerControl._canClick = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(!other.gameObject.CompareTag("Up") || !other.gameObject.CompareTag("Left") 
        || !other.gameObject.CompareTag("Right"))
        {
            _inTrigger = false;
        }    
    }
}
