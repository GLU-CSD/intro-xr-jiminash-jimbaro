
using UnityEngine;
using UnityEngine.UI;

public class Healthgiant : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthbarFill;



    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }


    private void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject, 1f);
        }
    }
    void UpdateHealthBar()
    {
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    public void RestoreHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

}

