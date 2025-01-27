using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightturnonandofscript : MonoBehaviour
{
    [SerializeField] private Light Lantern;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Geef de XR Rig de tag "Player"
        {
            Lantern.enabled = true;
            Debug.Log("Licht aan");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Lantern.enabled = false;
            Debug.Log("Licht uit");
        }
    }
}