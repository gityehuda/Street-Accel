using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public TrackLoop trackLoop1;
    public TrackLoop trackLoop2;
    public float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SpeedUp")
        {
            StartCoroutine(SpeedUp());
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator SpeedUp()
    {
        trackLoop1.speed = 30;
        trackLoop2.speed = 30;
        yield return new WaitForSeconds(duration);

        trackLoop1.speed = 20;
        trackLoop2.speed = 20;
    }

}
