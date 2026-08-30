using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 2 * _speed, 0);
    }
}
