using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingBehaviour : MonoBehaviour
{
    private float _verticalMovingDuration = 1f;
    private Vector3 _startState;
    private Vector3 _endState;
    private float _currentTime;

    private void Start()
    {
        _startState = transform.position;
        _endState = new Vector3(_startState.x, _startState.y + 3, _startState.y);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var movingStep = Mathf.PingPong(_currentTime, _verticalMovingDuration) / _verticalMovingDuration;
        transform.position = Vector3.Lerp(_startState, _endState, movingStep);
    }
}