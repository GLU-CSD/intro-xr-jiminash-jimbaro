using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordscript : MonoBehaviour
{
    public float damageAmount = 10f;       // Schade per aanval
    public float attackCooldown = 2f;      // Tijd tussen aanvallen
    private float lastAttackTime;          // Tijd sinds laatste aanval

    private Health EnemyHealth;       // Referentie Health script base


    void Update()
    {
        if (EnemyHealth != null && Time.time >= lastAttackTime + attackCooldown)
        {
            EnemyHealth.TakeDamage(damageAmount); // Schade doen aan de base
            lastAttackTime = Time.time; // Tijd van laatste aanval bijwerken
            Debug.Log(this.name + "attacked the base!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        // Zorg dat de base de tag "Base" heeft

        {
            EnemyHealth = other.gameObject.GetComponent<Health>();
        }

    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth = null;
            // Verwijdert de referentie wanneer de vijand de base verlaat
        }
    }
}
