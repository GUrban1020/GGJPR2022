using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speedUnitsPerSeconds = 3;
    public float lookX;
    public float lookY;
    public Animator animator;
  
    void FixedUpdate()
    {
        Vector3 input = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (input.x != 0)
            lookX = Mathf.Sign(input.x);
        
        if (input.y != 0)
            lookX = Mathf.Sign(input.y);

        if (animator)
        {
           // animator.SetFloat();
           // animator.SetFloat();
        }

        transform.position += input * speedUnitsPerSeconds * Time.fixedDeltaTime;
    }
}
