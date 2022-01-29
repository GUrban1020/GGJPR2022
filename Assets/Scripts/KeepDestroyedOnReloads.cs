using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KeepDestroyedOnReloads : MonoBehaviour
{
    public static List<string> ledger = new List<string>();
    string id;
    bool Onledger;
    void Awake()
    {
        id = SceneManager.GetActiveScene().name + gameObject.name + transform.GetSiblingIndex();
        Onledger = (ledger.Find((s) => s == id) == id);
        if (Onledger)
        {
            Destroy(gameObject);
        }
    }
    public void AddToLedger()
    {
       if (!Onledger) ledger.Add(id);

    }
    
}
