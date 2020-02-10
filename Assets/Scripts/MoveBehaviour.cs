using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveBehaviour : MonoBehaviour
{

    [SerializeField]
    private Vector2 _direction;
    [SerializeField]
    private float _velocity;

    private Rigidbody2D _rb;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    public void move()
    {
        _rb.MovePosition(new Vector2(transform.position.x + _velocity * _direction.x * Time.deltaTime,
                                     transform.position.y + _velocity * _direction.y * Time.deltaTime));

            /*
            transform.position = new Vector3(
            transform.position.x + _velocity * Time.deltaTime * _direction.x,
            transform.position.y + _velocity * Time.deltaTime * _direction.y,
            0);*/
    }

    public void move(Vector2 newdir)
    {
        _rb.MovePosition(new Vector2(transform.position.x + _velocity * newdir.x * Time.deltaTime,
                                     transform.position.y + _velocity * newdir.y * Time.deltaTime));
    }

    public void move(Vector3 newdir)
    {
        _rb.MovePosition(new Vector3(transform.position.x + _velocity * newdir.x * Time.deltaTime,
                                     transform.position.y + _velocity * newdir.y * Time.deltaTime,0));
    }
}
