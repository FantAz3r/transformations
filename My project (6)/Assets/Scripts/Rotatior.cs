using UnityEngine;

public class Rotatior : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 30.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}
