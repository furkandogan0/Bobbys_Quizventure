// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class Enemy : MonoBehaviour
// {
//     Rigidbody2D enemyRB;
//     Animator enemyAnimator;
//     public float moveSpeed = 1f;
//     bool facingRight = true;
//     void Start()
//     {
//         enemyRB = GetComponent<Rigidbody2D>();
//         enemyAnimator = GetComponent<Animator>();
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         HorizontalMove();
//
//         if (enemyRB.velocity.x < 0 && facingRight)
//         {
//             FlipFace();
//         }
//
//         else if (enemyRB.velocity.x > 0 && !facingRight)
//         {
//             FlipFace();
//         }
//     }
//     
//     void HorizontalMove()
//     {
//
//         enemyRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, enemyRB.velocity.y);
//         enemyAnimator.SetFloat("playerspeed", Mathf.Abs(enemyRB.velocity.x));
//     }
//     void FlipFace()
//     {
//         facingRight = !facingRight;
//         Vector3 tempLocalScale = transform.localScale;
//         tempLocalScale.x *= -1;
//         transform.localScale = tempLocalScale;
//
//     }
// }
