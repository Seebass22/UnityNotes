using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGun : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(bulletPrefab, transform.position, Camera.main.transform.rotation);
    }
}
