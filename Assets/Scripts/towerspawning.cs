using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerspawning : MonoBehaviour
{
    public GameObject towerPrefab;

    void OnCollisionEnter(Collision collision)
    {
        // Controleer of de grenade het terrein raakt
        if (collision.gameObject.CompareTag("Terrain"))
        {
            Debug.Log("ground touched");
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

