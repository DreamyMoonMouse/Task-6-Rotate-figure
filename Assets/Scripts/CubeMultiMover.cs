using UnityEngine;
using UnityEngine.Serialization;

public class CubeMultiMover : MonoBehaviour
{
    private Vector3 _direction = Vector3.forward;
    private Vector3 _rotation = Vector3.up;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    
    private void Update()
    {
        float speedChange = _moveSpeed * Time.deltaTime;
        transform.Translate(_direction*speedChange);
        float rotationChange = _rotationSpeed * Time.deltaTime;
        transform.Rotate(_rotation * rotationChange);
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += Vector3.one * scaleChange;
    }
}
