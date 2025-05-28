using System;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody2D carRb;

    private float x;
    
    void Awake()
    {
        carRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");

        //transform.position += Vector3.right * (speed * x * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        carRb.linearVelocityX = x * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log($"충돌:{other.gameObject.name}");
    }
}
