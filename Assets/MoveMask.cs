using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMask : MonoBehaviour
{
    public Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
       // Vector3 mpos = new Vector3( Input.mousePosition.x / cam.pixelWidth - 1, Input.mousePosition.y / cam.pixelHeight - 1);
        transform.position =  cam.ScreenPointToRay(Input.mousePosition).GetPoint(0);
    }
}
