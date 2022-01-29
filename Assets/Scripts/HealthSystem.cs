using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class HealthSystem : MonoBehaviour
{
    public static ReactiveProperty<float> lifePoints;
    void Start()
    {
        lifePoints = new ReactiveProperty<float>(3);
        lifePoints.AsObservable().Where(hp => hp <= 0).Do(_ => Ded()).Subscribe().AddTo(this);
    }
    void Ded()
    {
       // SceneLoader.ReLoadScene();
    }
    public void hurt()
    {
        lifePoints.Value--;
    }

}
