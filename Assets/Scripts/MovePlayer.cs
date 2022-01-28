using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speedUnitsPerSeconds = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 input = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += input * speedUnitsPerSeconds * Time.fixedDeltaTime;
    }
}
