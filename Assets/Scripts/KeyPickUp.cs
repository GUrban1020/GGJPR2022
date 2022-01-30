using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    [SerializeField] AudioClip got;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LockedDoor.keys++;
            AudioSource.PlayClipAtPoint(got, transform.position);
            Destroy(gameObject);
            GetComponent<KeepDestroyedOnReloads>().AddToLedger();
        }
    }
}
