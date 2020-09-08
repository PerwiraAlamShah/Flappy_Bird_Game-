using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Global Variable
    [SerializeField] private Transform shoot;
    [SerializeField] GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        // Menembak peluru
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    // Menduplikat peluru
    void Fire()
    {
        Instantiate(bullet,shoot.position, shoot.rotation);
    }
}
