using UnityEngine;

public class StraightMover : MonoBehaviour
{
    [SerializeField] private float _step = 4;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _step);
    }
}
