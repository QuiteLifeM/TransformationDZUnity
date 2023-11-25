using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _step;
    private int _borderScale = 3;
    private Vector3 _maxScale;
    private Vector3 _minScale;
    private Vector3 _targetScale;

    private void Awake()
    {
        _maxScale = Vector3.one * _borderScale;
        _minScale = Vector3.one;
    }

    private void Start()
    {
        _targetScale = _maxScale;
    }

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _targetScale, _step);

        if (transform.localScale == _maxScale)
        {
            _targetScale = _minScale;
        }
        else if (transform.localScale == _minScale)
        {
            _targetScale = _maxScale;
        }
    }
}
