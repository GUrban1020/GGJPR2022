using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagufinCode : MonoBehaviour
{
    public static int magufinColected = 0;
    readonly int MaxMagufinsColcted = 1;
    string sceneToLoadWhenGameIsDone = "End";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            magufinColected++;
            if (MaxMagufinsColcted == magufinColected) {
                SceneLoader.LoadScene("end", "exit1");
            }
            Destroy(gameObject);
        }
    }
}
