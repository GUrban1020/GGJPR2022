using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public static float lifePoints = 16;
    public Text ui;
    void Start()
    {
        lifePoints = 16;
        ui.text = "HP: " + lifePoints;
    }
    void Ded()
    {
       lifePoints = 16;
       ui.text = "HP: " + lifePoints;
       SceneLoader.ReLoadScene();
    }
    public void hurt()
    {
        lifePoints -= 1;
        ui.text = "HP: " + lifePoints;
        /*foreach (var item in ui)
        {
            item.SetActive(false);
        }
        if (lifePoints > 0)
        {
            for (int i = 0; i < lifePoints; i++)
            {
                ui[i].SetActive(true);
            }
        }*/

        Debug.Log("hit");
        if (lifePoints <= 0)
        {
            Ded();
        }
    }

}
