using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public int maxHealth = 100;
    private int currentHealth;

    public void SetMaxHealth(int health)
    {
        slider.value = health;
        // slider.maxValue = health; 
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
    void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Debug.Log("you are dead");
            //death animation
            //game over screen
        }
    }


}
