using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI counterText;
    [SerializeField] private int _count = 0;
    [SerializeField] private bool _isCounting = false;

    private void Start()
    {
        counterText.text = "—четчик: " + _count;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCounting();
            }
            else
            {
                StartCounting();
            }
        }
    }

    private void StartCounting()
    {
        _isCounting = true;
        StartCoroutine(Count());
    }

    private void StopCounting()
    {
        _isCounting = false;
        StopCoroutine(Count());
    }

    private IEnumerator Count()
    {
        while (_isCounting)
        {
            yield return new WaitForSeconds(0.5f);
            _count++;
            Debug.Log("—четчик: " + _count);
            counterText.text = "—четчик: " + _count; 
        }
    }
}
