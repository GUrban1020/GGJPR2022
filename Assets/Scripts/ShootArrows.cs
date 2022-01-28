using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrows : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject arrow;
    public float lifeTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0 && arrow == null)
        {
            arrow  = Instantiate(arrowPrefab);
            arrow.transform.position = transform.position;
            Destroy(arrow, lifeTime);
        }
    }
    void DestroyArrow()
    {
       // Destroy(arrow);
    }
}
