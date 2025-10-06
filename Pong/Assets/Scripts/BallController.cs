using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Rigidbody2D _rb;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        InitComponents();
    }
    
    private void InitComponents()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rb.linearVelocity = RandomDirection();
        RandomYPosition();
    }

    private Vector2 RandomDirection()
    {
        var x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        var y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        return new Vector2(x, y).normalized;
    }
    
    private void RandomYPosition()
    {
        var y = UnityEngine.Random.Range(-4f, 4f);
        transform.position = new Vector2(0, y);
    }
}
