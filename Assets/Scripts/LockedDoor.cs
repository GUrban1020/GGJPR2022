using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LockedDoor : MonoBehaviour
{
    public static int keys = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if ( other.gameObject.CompareTag("Player") && keys > 0)
        {
            Destroy(gameObject);
            GetComponent<KeepDestroyedOnReloads>().AddToLedger();
            keys--;
        }
    }
}
