using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoadGenerator : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveParentOfSpawnPoint(_speedMove);
    }

    private void MoveParentOfSpawnPoint(float speedMove)
    {
        _rb.velocity = new Vector3(0, 0, speedMove * Time.fixedDeltaTime);
    }
}
