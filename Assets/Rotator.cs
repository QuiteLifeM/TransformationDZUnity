using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _stepAngle;

    private void Update()
    {
        transform.Rotate(Vector3.up, _stepAngle * Time.deltaTime);
    }
}
