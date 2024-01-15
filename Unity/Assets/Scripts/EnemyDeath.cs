using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Tilemaps;

public class EnemyDeath : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite deadSprite;

    private void Reset()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        UpdateSprite();
        DisablePhysics();
        Animate();
    }

    private void UpdateSprite()
    { 
        spriteRenderer.enabled = true;
        spriteRenderer.sortingOrder = 10;

        if (deadSprite != null)
        {
            spriteRenderer.sprite = deadSprite;
        }
    }

    private void DisablePhysics()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }

    private IEnumerator Animate()
    {
        float elapsed = 0f;
        float duration = 3f;

        float jumpVelocity = 0f;
        float gravity = 10f;

        Vector3 velocity = Vector3.up * jumpVelocity;

        while (elapsed < duration)
        {
            transform.position += velocity * Time.deltaTime;
            velocity.y += gravity * Time.deltaTime;
            elapsed += Time.deltaTime;
            yield return null;
        }
        
        gameObject.SetActive(false);
    }
}
