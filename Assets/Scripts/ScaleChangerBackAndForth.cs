using UnityEngine;

public class ScaleChangerBackAndForth : MonoBehaviour
{
    [SerializeField] private float _speed;     
    [SerializeField] private float _scaleChangeAmount;
    
    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {        
        transform.localScale = new Vector3(ChangeScale(_startScale.x), ChangeScale(_startScale.y), ChangeScale(_startScale.z));
    }
    
    private float ChangeScale(float vectorComponent)
    {
        return Mathf.PingPong(Time.time * _speed, _scaleChangeAmount) + vectorComponent;
    }
}
