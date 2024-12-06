using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject[] objects;
    private int index;
    public float maxPosition = 4.0f;
    public float timeDelay = 1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeDelay;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 objectPosition = new Vector3(Random.Range(-4.0f, 4.0f), transform.position.y, transform.position.z);
            index = Random.Range(0, 8);
            Instantiate(objects[index], objectPosition, transform.rotation);
            timer = timeDelay;
        }

    }
}
