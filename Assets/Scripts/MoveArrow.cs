using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public float speed = 5;
    public float lifeTime = 1.5f;
    public bool doHarm = false;
    [HideInInspector()]
    public Vector3 dir;
    RaycastHit2D[] hits = new RaycastHit2D[3];
    private void OnEnable()
    {
        Destroy(gameObject,lifeTime);
    }
    void Update()
    {
        Vector3 scaledDir = dir * speed * Time.deltaTime;
        
        transform.position += scaledDir;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == false)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && doHarm)
        {
            if (collision.gameObject.TryGetComponent<HealthSystem>(out HealthSystem hp))
            {
                hp.hurt();
            }
        }
        Destroy(gameObject);
    }

}
