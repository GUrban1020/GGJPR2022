using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class BulletEmiter : MonoBehaviour
{
    public GameObject buletPrefab;
    [SerializeField()] Vector3 shDir = Vector3.down;
    [SerializeField()] float shotrate = 5;
    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable().Where(_ => { return (Time.timeSinceLevelLoad - shotTimeStamp >= shotrate); })
            .Do(_ => Shoot(shDir)).Subscribe().AddTo(this);
    }

    
    float shotTimeStamp;
    void Shoot(Vector3 dir)
    {
        shotTimeStamp = Time.timeSinceLevelLoad;
        var bullet = Instantiate(buletPrefab).GetComponent<MoveArrow>();

        bullet.transform.position = transform.position;
        bullet.dir = dir;
        bullet.transform.right = dir;

        bullet.transform.rotation = Quaternion.Euler(0, 0, bullet.transform.rotation.eulerAngles.z);

    }
}
