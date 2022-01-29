using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInDarknesDetector : MonoBehaviour
{
    public Transform Mask;
    public bool isInDarkness;
    //[SerializeField] float radius = 4;//radxius
    
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,Mask.position) < Mask.localScale.x/2)
        {
            gameObject.layer = 7;
            isInDarkness = true;
        }
        else
        {
            gameObject.layer = 6;
            isInDarkness = false;

        }
    }

    
}
