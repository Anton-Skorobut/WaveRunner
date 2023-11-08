using UnityEngine;

public class ScaleBehaviour : MonoBehaviour
{
    private float _scaleDuration = 1f;
    private int _increesLevel = 2;
    private float _time;
    private Vector3 _startScale;
    private Vector3 _endScale;

    private void Start()
    {
        _startScale = transform.localScale;
        _endScale = _startScale * _increesLevel;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        var scalingStep = Mathf.PingPong(_time, _scaleDuration) / _scaleDuration;
        transform.localScale = Vector3.Lerp(_startScale, _endScale, scalingStep);
    }
}