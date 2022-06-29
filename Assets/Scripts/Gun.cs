using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public float shootForce;

    private GameObject _tempBullet;

    public void Shoot()
    {
        _tempBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        _tempBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce, ForceMode.Impulse);
        Destroy(_tempBullet, 5f);
    }
}
