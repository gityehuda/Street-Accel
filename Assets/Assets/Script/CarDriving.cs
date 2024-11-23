using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    public float speed;
    public float fuel = 30;
    public float maxfuel = 30;
    Vector3 position;
    public float maxPosition = 4.8f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -maxPosition, maxPosition);
        transform.position = position;
        fuel -= Time.deltaTime;
    }

}
