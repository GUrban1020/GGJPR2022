using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingTrigger : MonoBehaviour
{
    public string sceneName = "",playerSpawnGameObjectName = "";
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            try
            {
            SceneLoader.LoadScene(sceneName, playerSpawnGameObjectName);
            }
            catch (System.Exception)
            {
                Debug.LogError("Secne:" + sceneName + " does not exist or its not added to build");
                throw;
            }
        }
    }
}
