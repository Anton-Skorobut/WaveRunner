using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    private float _rotationDuration = 1f;

    private void Update()
    {
        transform.Rotate(-Vector3.back, _rotationDuration);
    }
}