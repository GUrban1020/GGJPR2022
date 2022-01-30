using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class BulletEmiter : MonoBehaviour
{
    public GameObject buletPrefab;
    [SerializeField()] Vector3 shDir = Vector3.down;
    [SerializeField()] float turnRate = 0;
    [SerializeField()] float shotrate = 5;
    [SerializeField()] float speed = 1;
    [SerializeField()] float lifeTime = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        this.UpdateAsObservable().Where(_ => { return (Time.timeSinceLevelLoad - shotTimeStamp >= shotrate); })
            .Do(_ => Shoot()).Subscribe().AddTo(this);
    }

    
    float shotTimeStamp;
    void Shoot()
    {
        shotTimeStamp = Time.timeSinceLevelLoad;
        var bullet = Instantiate(buletPrefab).GetComponent<MoveArrow>();
        shDir =  Quaternion.Euler(0,0,turnRate) * shDir;
        bullet.transform.position = transform.position;
        bullet.dir = shDir;
        bullet.transform.right = shDir;
        bullet.lifeTime = lifeTime;
        bullet.speed = speed;
        bullet.transform.rotation = Quaternion.Euler(0, 0, bullet.transform.rotation.eulerAngles.z);

    }
}
