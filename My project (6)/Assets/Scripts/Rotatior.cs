using UnityEngine;

public class Rotatior : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 30.0f;

    private void Update()
    {
        transform.Rotate(transform.up * (_rotationSpeed * Time.deltaTime));
    }
}
