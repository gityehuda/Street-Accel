using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour
{
    private CarDriving cd;

    // Start is called before the first frame update
    void Awake()
    {
        cd = FindObjectOfType<CarDriving>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "Bound")
        {
            cd.coin += 10;
            Destroy(gameObject);
        }
    }

}
