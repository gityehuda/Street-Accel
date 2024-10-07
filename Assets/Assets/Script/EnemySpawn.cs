using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
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
        if(timer <= 0)
        {
            Vector3 carPosition = new Vector3(Random.Range(-4.0f, 4.0f), transform.position.y, transform.position.z);
            Instantiate(enemy, carPosition, transform.rotation);
            timer = timeDelay;
        }
        
    }
}
