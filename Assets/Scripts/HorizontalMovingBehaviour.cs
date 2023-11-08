using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingBehaviour : MonoBehaviour
{
    private float _horizontalMovingDuration = 1f;
    private float _offset = 2;
    private Vector3 _startState;
    private Vector3 _endState;
    private float _currentTime;
    private bool _isMovingLeft;

    private void Start()
    {
        _startState = transform.position;
        _isMovingLeft = Random.Range(0, 2) != 1;
        ChangeDirection();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var movingStep = Mathf.PingPong(_currentTime, _horizontalMovingDuration) / _horizontalMovingDuration;
        transform.position = Vector3.Lerp(_startState, _endState, movingStep);
    }

    private void ChangeDirection()
    {
        _endState = _isMovingLeft
            ? new Vector3(_startState.x - _offset, _startState.y, _startState.z)
            : new Vector3(_startState.x + _offset, _startState.y, _startState.z);
        _isMovingLeft = !_isMovingLeft;
    }
}