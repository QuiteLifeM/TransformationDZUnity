using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private List<Transform> _targets;
    private float _speed = 2;
    private Vector3 _targetPosition;
    Queue<Transform> _targetsQueue;

    private void Awake()
    {
        _targetsQueue = new Queue<Transform>(_targets);
    }

    private void Start()
    {
        SetNextTarget();
    }

    private void Update()
    {
        Vector3 current = transform.position;
        transform.position = Vector3.MoveTowards(current, _targetPosition, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _targetPosition) < 0.1)
        {
            SetNextTarget();
        }
    }

    private void SetNextTarget()
    {
        Transform target = _targetsQueue.Dequeue();
        _targetPosition = target.position;
        _targetsQueue.Enqueue(target);
    }
}
