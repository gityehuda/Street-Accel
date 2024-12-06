using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public TrackLoop trackLoop1;
    public TrackLoop trackLoop2;
    public float duration;
    public GameObject shield;
    public bool isProtected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SpeedUp")
        {
            StartCoroutine(PowerUp());
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator PowerUp()
    {
        trackLoop1.speed = 30;
        trackLoop2.speed = 30;
        shield.SetActive(true);
        isProtected = true;
        yield return new WaitForSeconds(duration);

        shield.SetActive(false);
        trackLoop1.speed = 20;
        trackLoop2.speed = 20;
        isProtected = false;
    }

}
