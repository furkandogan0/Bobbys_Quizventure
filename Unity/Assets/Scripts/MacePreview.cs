



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacePreview : MonoBehaviour
{
    
    private Rigidbody2D rb;



    
    // public Transform top_collision;
    
   
    public float damage;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

 
   
    }

    // Update is called once per frame




    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerManager>().GetDamage(damage);
        }
    }

    // private void CheckCollision()
    // {
    //     Collider2D topHit = Physics2D.OverlapCircle(top_collision.position, 0.2f);
    //
    //     if (topHit != null)
    //     {
    //         if (topHit.gameObject.CompareTag("Player"))
    //         {
    //             topHit.gameObject.GetComponent<Rigidbody2D>().velocity =
    //                 new Vector2(topHit.gameObject.GetComponent<Rigidbody2D>().velocity.x, 7f);
    //             
    //         }   
    //     }
    // }
}
