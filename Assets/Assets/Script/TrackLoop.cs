using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrackLoop : MonoBehaviour
{
    public float speed;
    public GameObject[] gameObjects;
    public UnityEvent<SpriteRenderer> OnImageMoved;
    //float elapsedTime;
    //BackgroundContainer[] bc;
    // Update is called once per frame
    void Update()
    {
        //elapsedTime += Time.deltaTime;
        //if(elapsedTime > 30 ) 
        //{
        //    ChangeBackground();
        //}
        for (int i=0;i<gameObjects.Length; i++)
        {
            gameObjects[i].transform.position += Vector3.down * Time.deltaTime * speed;
            if (gameObjects[0].transform.position.y <= -27)
            {
                gameObjects[0].transform.position = gameObjects[1].transform.position + new Vector3(0, 27, 0);
                OnImageMoved?.Invoke(gameObjects[0].GetComponent<SpriteRenderer>());
                GameObject temp = gameObjects[0];
                gameObjects[0] = gameObjects[1];
                gameObjects[1] = temp;
            }
        }
        //foreach(GameObject go in gameObjects)
        //{
        //    go.transform.position += Vector3.down * Time.deltaTime * speed;
        //    if(go.transform.position.y <= -27) 
        //    {
        //        go.transform.position = new Vector3(0, 27 - (go.transform.position.y+27), 0);
        //        OnImageMoved?.Invoke(go.GetComponent<SpriteRenderer>());
        //    }
        //}
    }
}
