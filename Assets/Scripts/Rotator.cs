using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private Vector3 _rotation = Vector3.up;
    
    private void Update()
    {
        float speedChange = _rotationSpeed * Time.deltaTime;
        transform.Rotate(_rotation * speedChange);
    }
}
