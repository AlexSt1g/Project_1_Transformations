using UnityEngine;

public class MoverBackAndForth : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private Vector3 _startPosition;  

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * _speed, _distance) + _startPosition.z);
    }
}
