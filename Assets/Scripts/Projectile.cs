using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //config
    [SerializeField] float projectileSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
        //transform.Rotate(new Vector3(0, 0, 10 * Time.deltaTime));
    }
}
