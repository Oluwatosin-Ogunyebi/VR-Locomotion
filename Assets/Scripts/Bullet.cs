using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Color _bulletColor;
    public MeshRenderer bulletMaterial;

    private void Awake()
    {
        _bulletColor = Random.ColorHSV();
        bulletMaterial.GetComponent<MeshRenderer>().material.color = _bulletColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MeshRenderer>() != null)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = _bulletColor;
        }
    }
}
