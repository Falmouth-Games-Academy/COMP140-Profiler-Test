using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    Transform bulletSpawnPoint;

    [SerializeField]
    GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate<GameObject>(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
}
