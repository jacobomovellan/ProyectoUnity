using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalaScript : MonoBehaviour
{
     public float Speed;
     private Rigidbody2D Rigidbody2D;
     private Vector2 Direction;

    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        Rigidbody2D.linearVelocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void DestroyBala()
    {
        Destroy(gameObject);
    }
}
