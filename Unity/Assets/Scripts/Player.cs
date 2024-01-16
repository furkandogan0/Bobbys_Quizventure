//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player : MonoBehaviour
//{

//    Rigidbody2D playerRB;
//    Animator playerAnimator;
//    public float moveSpeed = 1f;
//    public float jumpSpeed = 1f, jumpFrequency = 1f, nextJumpTime;

//    bool facingRight = true;
//    public float maxXPosition; // Karakterin maksimum x pozisyonu

//    public bool isGrounded = false;
//    public Transform groundCheckPosition;
//    public float groundCheckRadius;
//    public LayerMask groundCheckLayer;
//    // Start is called before the first frame update
//    void Start()
//    {
//        playerRB = GetComponent<Rigidbody2D>();
//        playerAnimator = GetComponent<Animator>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        HorizontalMove();
//        OnGroundCheck();

//        if (playerRB.velocity.x < 0 && facingRight)
//        {
//            FlipFace();
//        }

//        else if (playerRB.velocity.x > 0 && !facingRight)
//        {
//            FlipFace();
//        }

//        if (Input.GetAxis("Vertical") > 0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad))
//        {
//            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
//            Jump();
//        }
//    }
//    void HorizontalMove()
//    {
//        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
//        playerAnimator.SetFloat("playerspeed", Mathf.Abs(playerRB.velocity.x));
//    }
//    void FlipFace()
//    {
//        facingRight = !facingRight;
//        Vector3 tempLocalScale = transform.localScale;
//        tempLocalScale.x *= -1;
//        transform.localScale = tempLocalScale;

//    }

//    void Jump()
//    {
//        playerRB.AddForce(new Vector2(0f, jumpSpeed));
//    }

//    void OnGroundCheck()
//    {
//        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);
//        playerAnimator.SetBool("isGroundedAnim", isGrounded);
//    }







using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRB;
    Animator playerAnimator;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f, jumpFrequency = 1f, nextJumpTime;
    bool facingRight = true;
    public TMP_Text anahtarSayisiMetni; // UI Text objesini buraya atayın

    public float minXPosition; // Karakterin minimum x pozisyonu
    public float maxXPosition; // Karakterin maksimum x pozisyonu

    public bool isGrounded = false;
    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        anahtarSayisiMetni.text = "0"+"X";
    }

    void Update()
    {
        HorizontalMove();
        OnGroundCheck();

        if (playerRB.velocity.x < 0 && facingRight)
        {
            FlipFace();
        }

        else if (playerRB.velocity.x > 0 && !facingRight)
        {
            FlipFace();
        }

        if (Input.GetAxis("Vertical") > 0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad))
        {
            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
            Jump();
        }

        anahtarSayisiMetni.text = "" + GameManager.instance.kazanilanAnahtarSayisi;

    }

    void HorizontalMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if ((horizontalInput < 0 && transform.position.x > minXPosition) || (horizontalInput > 0 && transform.position.x < maxXPosition))
        {
            playerRB.velocity = new Vector2(horizontalInput * moveSpeed, playerRB.velocity.y);
            playerAnimator.SetFloat("playerspeed", Mathf.Abs(playerRB.velocity.x));
        }
        else if ((horizontalInput < 0 && transform.position.x <= minXPosition) || (horizontalInput > 0 && transform.position.x >= maxXPosition))
        {
            playerRB.velocity = new Vector2(0, playerRB.velocity.y); // Sınıra ulaşıldığında hareketi durdur
            playerAnimator.SetFloat("playerspeed", 0);
        }
    }
    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;

    }

    void Jump()
    {
        playerRB.AddForce(new Vector2(0f, jumpSpeed));
    }
    void OnGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);
        playerAnimator.SetBool("isGroundedAnim", isGrounded);
    }

    //public void GuncelleAnahtarMetni()
    //{
    //    // Anahtar sayısını UI Text objesine yazdır
    //    anahtarSayisiMetni.text = GetComponent<GameManager>().kazanilanAnahtarSayisi.ToString();
    //}

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         // Düşmanın üstüne çarpıldığında
    //         Enemy enemy = collision.gameObject.GetComponent<Enemy>();
    //
    //         if (enemy != null)
    //         {
    //             // Düşmanın ölüm fonksiyonunu çağır
    //             Destroy(collision.gameObject);
    //
    //             // Düşmanın üstüne zıplandığında karakteri bir miktar yukarı it
    //             playerRB.AddForce(new Vector2(0f, jumpSpeed / 2f));
    //         }
    //     }
    // }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Düşmanın altına çarpıldığında
            if (IsCollisionBelow(collision))
            {
                Destroy(collision.gameObject);
                
                // Düşmanın altına zıplandığında karakteri bir miktar yukarı it
                playerRB.AddForce(new Vector2(0f, jumpSpeed / 2f)); 
            }
        }
    }
    

    // Düşmanın altına çarpılıp çarpılmadığını kontrol etmek için yardımcı bir fonksiyon
    bool IsCollisionBelow(Collision2D collision)
    {
        // Çarpışmanın normali (çarpışmanın yüzeyine dik olan vektör)
        Vector2 contactNormal = collision.GetContact(0).normal;

        // Yüzeyin yukarı yönlü olup olmadığını kontrol et
        return Vector2.Dot(contactNormal, Vector2.up) > 0.5f;
    }
}




