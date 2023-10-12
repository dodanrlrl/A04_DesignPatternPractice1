using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void Shoot()
    {
        //Destroy(gameObject, 5f);
        Invoke(nameof(DestroyBullet), 5f);
    }
    private void DestroyBullet()
    {
        ObjectPool.ReturnObj(this);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left);
    }
}
