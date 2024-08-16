using UnityEngine;
using UnityEngine.Serialization;

public class SphereMover : MonoBehaviour
{
    private Vector3 _direction = Vector3.forward;
    [SerializeField] private float _moveSpeed;
    
    private void Update()
    {
        float speedChange = _moveSpeed * Time.deltaTime;
        transform.Translate(_direction*speedChange);
    }
}
