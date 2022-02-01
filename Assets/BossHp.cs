using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHp : MonoBehaviour
{

    float hp = 25;
    public GameObject magufin;
    public Transform[] teleportspots;
    [SerializeField] AudioClip audioClip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("arrow"))
        {
            hp--;
            if (hp <= 0)
            {
                Destroy(gameObject);
                magufin.SetActive(true);
                magufin.transform.position = transform.position;
                return;
            }
            int p = Random.Range(minInclusive: 0, maxExclusive: teleportspots.Length);
            transform.position = teleportspots[p].position;
            AudioSource.PlayClipAtPoint(audioClip,transform.position); 
            Destroy(other.gameObject);
        }
    }
}
