using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speedUnitsPerSeconds = 3;
    public float lookX;
    public float lookY;
    public bool IsMoving;
    public Animator[] animators;
    public AudioClip[] footsteps;
    float timestamp;

    void FixedUpdate()
    {
        Vector3 input = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       // if (input.x != 0)
           // lookX = Mathf.Sign(input.x);
        
        //if (input.y != 0)
            //lookX = Mathf.Sign(input.y);

        IsMoving = (input != Vector3.zero);
        foreach (var animator in animators)
        {
            animator.SetFloat("lookY", input.y);
            animator.SetBool("isMoving", IsMoving);
            animator.SetFloat("lookX", input.x);
        }
        
        if (IsMoving && (Time.timeSinceLevelLoad - timestamp) > 0.8f )
        {
            timestamp = Time.timeSinceLevelLoad;
            int p = Random.Range(minInclusive: 0, maxExclusive: footsteps.Length) ;
            AudioSource.PlayClipAtPoint(footsteps[p],transform.position);
        }
        transform.position += input * speedUnitsPerSeconds * Time.fixedDeltaTime;
    }
}
