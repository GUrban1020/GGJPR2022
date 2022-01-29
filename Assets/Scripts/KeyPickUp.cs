using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LockedDoor.keys++;
            Destroy(gameObject);
            GetComponent<KeepDestroyedOnReloads>().AddToLedger();
        }
    }
}
