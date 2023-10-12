using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject bulletObj;

    private void Start()
    {
       InvokeRepeating("ShootBullet", 1f, 4f);
       InvokeRepeating("ShootBullet", 1.05f, 4f);
       InvokeRepeating("ShootBullet", 1.1f, 4f);
       InvokeRepeating("ShootBullet", 1.15f, 4f);
       InvokeRepeating("ShootBullet", 1.2f, 4f);
       InvokeRepeating("ShootBullet", 1.25f, 4f);
    }
   
    public void ShootBullet()
    {
        //Bullet bullet = Instantiate(bulletObj).GetComponent<Bullet>();
        Bullet bullet = ObjectPool.GetObject();
        bullet.Shoot();

    }

}
