using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour
{
    private CarDriving cd;

    void Awake()
    {
        cd = FindObjectOfType<CarDriving>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cd.fuel += 10;
        Destroy(gameObject);
    }
}
