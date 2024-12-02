using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleFrame : MonoBehaviour
{
    public float duration;
    public GameObject shield;

    public void activate()
    {
        StartCoroutine(blink());
        deactivateCollider();
    }

    private void deactivateCollider()
    {
        GetComponent<Collider2D>().enabled = false;
    }

    private void activateCollider()
    {
        GetComponent<Collider2D>().enabled = true;
    }

    private IEnumerator blink()
    {
        yield return new WaitForSeconds(duration);
       
        shield.SetActive(false);
        activateCollider();
    }

}
