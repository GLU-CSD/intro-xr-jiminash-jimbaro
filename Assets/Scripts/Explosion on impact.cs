using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Explosiononimpact : MonoBehaviour
{
    public float explosionForce = 500f;      // Kracht van de explosie
    public float explosionRadius = 5f;       // Radius van de explosie
    private Health EnemyHealth;       // Referentie Health script base
    public float explosionDamage = 10;
    public bool stun;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Zorg dat vijanden de tag "Enemy" hebben
        {

            Explode();
            Destroy(gameObject); // Verwijder het object na de explosie
            {
                
            }
        }
    }


  
   



    void Explode()
    {

     

        // Vind alle objecten in de buurt van de explosie
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
        
          EnemyHealth  = nearbyObject.GetComponent<Health>();
            stun = nearbyObject.GetComponent<NavMeshAgent>();
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
        EnemyHealth.TakeDamage(explosionDamage);
        if (stun != null)
        {
            stun = false;
        }

    }
  
     

}