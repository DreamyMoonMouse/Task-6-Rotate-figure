using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    private Vector3 _rotation = Vector3.up;
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
        float speedChange = _rotationSpeed * Time.deltaTime;
        transform.Rotate(_rotation * speedChange);
    }
}
