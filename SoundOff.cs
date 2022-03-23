using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour
{
    [SerializeField] private GameObject _soundOff;

    [SerializeField] private AudioSource _sound;

    private Animator _animator;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    public void OnClickButtonOff()
    {
        _sound.Play();

        _animator.SetTrigger("PlayScale");
    }

    public void EnableSound()
    {
        AudioListener.volume = 1;

        _soundOff.SetActive(true);
        gameObject.SetActive(false);
    }
}
