using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedBoost : MonoBehaviour
{
    public TrackLoop trackLoop1;
    public TrackLoop trackLoop2;
    public float duration;
    public GameObject shield;
    public bool isProtected = false;
    public float currentTime;
    private SpriteRenderer sr;

    public Action OnBuffGained; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SpeedUp")
        {
            if (isProtected == false)
            {
                currentTime = duration;
                StartCoroutine(PowerUp());
                OnBuffGained.Invoke();
                Destroy(collision.gameObject);
            }
            Destroy(collision.gameObject);
        } 
    }

    void Awake()
    {
         sr = shield.GetComponent<SpriteRenderer>();   
    }

    void Update()
    {
        if(currentTime < 0) 
        {
            return;
        }
        currentTime -= Time.deltaTime;    
    }

   /* private IEnumerator Start()
    {
        Color solid = sr.color;
        solid.a = 1.0f;
        Color alpha = sr.color;
        alpha.a = 0f;
        float delay = .5f;

        while (true)
        {
            if (currentTime < 4)
            {
                sr.color = solid;
                yield return new WaitForSeconds(delay);
                sr.color = alpha;
                yield return new WaitForSeconds(delay);
            }
            
        yield return null;

        }
    }*/

    private IEnumerator PowerUp()
    {
        Color solid = sr.color;
        solid.a = 1f;
        sr.color = solid;
        /* Color alpha = sr.color;
         alpha.a = 0f;
         float delay = .5f;
 */
         trackLoop1.speed *= 1.5f;
         trackLoop2.speed *= 1.5f;
         shield.SetActive(true);
         isProtected = true;

        /*if (currentTime < 4)
        {
            
            yield return new WaitForSeconds(delay);
            sr.color = alpha;
            yield return new WaitForSeconds(delay);
        }*/

        yield return new WaitForSeconds(duration);

        shield.SetActive(false);
        trackLoop1.speed /= 1.5f;
        trackLoop2.speed /= 1.5f;
        isProtected = false;
    }

}
