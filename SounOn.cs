using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounOn : MonoBehaviour
{
    [SerializeField] private GameObject _soundOn;

    [SerializeField] private AudioSource _sound;

    private Animator _animator;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    public void OnClickButton()
    {
        _sound.Play();

        _animator.SetTrigger("PlayScale");
    }

    public void DisableSound()
    {
        AudioListener.volume = 0;

        _soundOn.SetActive(true);
        gameObject.SetActive(false);
    }
}
