using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static string playerSpawn;
    static GameObject playerObject;
    private void Start()
    {
        if (playerObject == null)
        {
            playerObject = gameObject;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        }
        else Destroy(gameObject);
    }

    private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode arg1)
    {
        var spawnpoint = GameObject.Find(playerSpawn);
        if (spawnpoint != null)
            playerObject.transform.GetChild(0).position = spawnpoint.transform.position;
        else
        {
            playerObject.transform.GetChild(0).position = Vector3.zero;
          Debug.Log($"GameObject named: {playerSpawn} Not found in scene: {scene.name}; teleporting to 0,0");
        }
    }

    public static void LoadScene(string sceneName, string playerSpawn)
    {
        SceneLoader.playerSpawn = playerSpawn;
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}