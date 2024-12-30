using UnityEngine;

public class MoverForvard : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
