using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Height : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _vector = new Vector3(1, 1, 1);

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= _speed)
        {
            transform.localScale += _vector;
            timer = 0;
        }
        
    }
}
