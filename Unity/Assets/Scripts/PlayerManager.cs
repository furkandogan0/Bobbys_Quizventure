using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health;
    bool dead = false;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {
        
    }

    public void GetDamage(float damage)
    {
        if ((health - damage) >= 10)
        {
            health -= damage;
        }
        else
        {
            health = 10;
            SceneManager.LoadScene("GameOverScreen");
        }
        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            dead = true;
        }
    }
}
