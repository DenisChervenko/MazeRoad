using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private AudioSource _soundClick;

    [SerializeField] private float _speedMoveForward;
    [SerializeField] private float _speedMoveLeft;
    [SerializeField] private float _speedMoveRight;

    // 0 - up
    // 1 - left
    // 2 - right
    static public int _direction;
    static public bool _canClick = false;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = _player.GetComponent<Rigidbody>();
    }

    public void OnClick()
    {
        if(_canClick)
        {
            if(_direction == 0)
            {
                _particle.Play();
                _soundClick.Play();
                _rb.velocity = new Vector3(0, 0, _speedMoveForward * Time.fixedDeltaTime);
            }
            else if(_direction == 1)
            {
                _particle.Play();
                _soundClick.Play();
                _rb.velocity = new Vector3(_speedMoveLeft * Time.fixedDeltaTime, 0, -_speedMoveForward * Time.fixedDeltaTime);
            }
            else if(_direction == 2)
            {
                _particle.Play();
                _soundClick.Play();
                _rb.velocity = new Vector3(_speedMoveRight * Time.fixedDeltaTime, 0, -_speedMoveForward * Time.fixedDeltaTime);
            }
        }
        
    }
}
