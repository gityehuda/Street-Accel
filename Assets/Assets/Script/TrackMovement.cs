using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMovement : MonoBehaviour
{
    public Transform[] background;
    public float speed;

    [Header("Posisi Y di atas kamera")]
    public float topPosY;

    [Header("Posisi Y di bawah kamera")]
    public float bottomPosY;

    void Update()
    {
        positionUpdate();
        checkPosition();
    }

    private void checkPosition()
    {
        if (background[0].transform.position.y < bottomPosY)
        {
            background[0].transform.position = new Vector3(0, topPosY, 0);

        }
        if (background[1].transform.position.y < bottomPosY)
        {
            background[1].transform.position = new Vector3(0, topPosY, 0);
        }
    }

    private void positionUpdate()
    {
        var movement = Time.deltaTime * speed;
        background[0].transform.position = new Vector3(0, background[0].position.y - movement, 0);
        background[1].transform.position = new Vector3(0, background[1].position.y - movement, 0);
    }
}
