using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public TrackLoop trackLoop1;
    public TrackLoop trackLoop2;
    public float duration;
    public GameObject shield;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SpeedUp")
        {
            StartCoroutine(PowerUp());
            Destroy(collision.gameObject);
            deactivateCollider();
        }
    }

    private void deactivateCollider()
    {
        GetComponent<Collider2D>().enabled = false;
    }

    private void activateCollider()
    {
        GetComponent<Collider2D>().enabled = true;
    }

    private IEnumerator PowerUp()
    {
        trackLoop1.speed = 30;
        trackLoop2.speed = 30;
        shield.SetActive(true);
        yield return new WaitForSeconds(duration);

        shield.SetActive(false);
        activateCollider();
        trackLoop1.speed = 20;
        trackLoop2.speed = 20;
    }

}
