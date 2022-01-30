using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LockedDoor : MonoBehaviour
{
    [SerializeField] AudioClip got;
    public static int keys = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if ( other.gameObject.CompareTag("Player") && keys > 0)
        {
            AudioSource.PlayClipAtPoint(got, transform.position);
            Destroy(gameObject);
            GetComponent<KeepDestroyedOnReloads>().AddToLedger();
            keys--;
        }
    }
}
