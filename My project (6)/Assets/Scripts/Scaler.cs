using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * (_scaleSpeed * Time.deltaTime);
    }
}
