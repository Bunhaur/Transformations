using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _increase;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}