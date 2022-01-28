using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiled : MonoBehaviour
{
    public Vector3 screenSize;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 p = target.position;
        for (int i = 0; i < 3; i++)
        {
            p[i] = Mathf.Round(p[i] / screenSize[i]) * screenSize[i];
        }
        p.z = -10;
        transform.position = p;
       // transform.position = Grid.Swizzle(GridLayout.CellSwizzle.XYZ,p);
    }
}
