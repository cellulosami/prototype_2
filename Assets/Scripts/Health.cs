using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth = 0;
    public Slider healthbar;

    void Start() {
        healthbar.maxValue = maxHealth;
        healthbar.value = 0;
        healthbar.fillRect.gameObject.SetActive(false);
    }

    public void TakeDamage(int amount) {
        currentHealth += amount;
        healthbar.fillRect.gameObject.SetActive(true);
        healthbar.value = currentHealth;

        if (currentHealth >= maxHealth) {
            Debug.Log("HUNGER SATIATED");
            Destroy(gameObject);
        }
    }
}
