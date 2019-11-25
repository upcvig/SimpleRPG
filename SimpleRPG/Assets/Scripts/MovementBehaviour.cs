using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public virtual void Move(Vector3 direction)
    {
        _rigidbody.MovePosition(transform.position + direction * _speed * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(movX, movY, 0);
        Move(dir);
        _spriteRenderer.flipX = movX > 0 ? false : true;
        _animator.SetFloat("speed", System.Math.Abs(movX + movY));
    }
}
