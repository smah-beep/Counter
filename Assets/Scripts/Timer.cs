using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _delay;

    private float _valueCounter = 0;
    private bool _isClick = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && _isClick == false)
        {
            _isClick = true;
            StartCoroutine(CountdownTime());           
        }
        else if (Input.GetMouseButtonDown(0) && _isClick == true)
        {
            StopCoroutine(CountdownTime());
            _isClick = false;
        }
    }

    private IEnumerator CountdownTime()
    {
        while (_isClick == true)
        {
            WaitForSeconds _wait = new WaitForSeconds(_delay);
            yield return _wait;
            _valueCounter++;
            Debug.Log(_valueCounter);
        }       
    }
}
