using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrows : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform mask;
    float coolDown = 1f;

    MoveArrow arrow;
    float shotTimeStamp = 0;
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0 && ( arrow == null || Time.timeSinceLevelLoad - shotTimeStamp > coolDown))
        {
            shotTimeStamp = Time.timeSinceLevelLoad;
            arrow = Instantiate(arrowPrefab).GetComponent<MoveArrow>();

            Vector3 n = mask.transform.position - transform.position;
            arrow.transform.position = transform.position;
            arrow.dir = n.normalized;
            arrow.transform.right = n.normalized;

            arrow.transform.rotation = Quaternion.Euler(0, 0, arrow.transform.rotation.eulerAngles.z);

        }
    }
    
}
