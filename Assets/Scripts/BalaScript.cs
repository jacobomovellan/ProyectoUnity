using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalaScript : MonoBehaviour
{
     public AudioClip Sound;
     public float Speed;
     private Rigidbody2D Rigidbody2D;
     private Vector2 Direction;

    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
        
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        John1 john = collision.GetComponent<John1>();
        GruntArchivo grunt = collision.GetComponent<GruntArchivo>();
        if (john != null)
        {
            john.Hit();
        }
        if(grunt != null)
        {
            grunt.Hit();
        }
        DestroyBala();
    }
}
