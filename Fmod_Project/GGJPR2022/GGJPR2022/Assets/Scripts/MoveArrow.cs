using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public float speed = 5;
    public float lifeTime = 1.5f;

    [HideInInspector()]
    public Vector3 dir;
    RaycastHit2D[] hits = new RaycastHit2D[3];
    private void OnEnable()
    {
        //transform.rotation = Quaternion.Euler(0, 0, Vector3.SignedAngle(transform.position, dir, Vector3.forward));

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
            Debug.Log(gameObject.name);
            Destroy(gameObject);
        }
    }
   
}
