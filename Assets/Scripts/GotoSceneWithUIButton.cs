using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class GotoSceneWithUIButton : MonoBehaviour
{
    public string SceneToLoad;
    // It adds the click on button funtionatiy automaticly;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            try
            {
                if (SceneToLoad != "") SceneManager.LoadScene(SceneToLoad);
                else Debug.LogWarning("Forgot to add scene to script", this);
            }
            catch
            {
                Debug.LogWarning("Scene Not found " + SceneToLoad, this);
            }
        });

    }
  //  public void load( string scene) =>  SceneManager.LoadScene(scene);/
}
