using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector3 _direction = Vector3.forward;
    
    private void Update()
    {
        float speedChange = _moveSpeed * Time.deltaTime;
        transform.Translate(_direction*speedChange);
    }
}
