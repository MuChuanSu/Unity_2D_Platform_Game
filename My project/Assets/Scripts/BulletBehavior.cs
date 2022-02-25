using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    Rigidbody2D myRigid;
    PlayerMovement player;
    [SerializeField] float bulletSpeed = 10f;
    float xSpeed;
    //uses a component that player has to represent player
    //or I can use a tag

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject); // this means destroy the bullet itself
    }

    void OnCollisionEnter2D(Collider2D other)
    {
      
        Destroy(gameObject); // this means destroy the bullet itself
    }

    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x*bulletSpeed;
        //player.transform.localScale let us know which direction
        //the player is facing,multiply by it will generate a positive or negative number
        //we ten assign it as the bullets velocity x ;
    }

    
    void Update()
    {
        myRigid.velocity = new Vector2(xSpeed, 0f); 
    }

    
}
