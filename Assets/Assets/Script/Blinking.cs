using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpeedBoost sb;
    //public float currentTime = 7;
    private SpriteRenderer sr;
    private GameObject go;

    // Start is called before the first frame update
    void Awake()
    {
        go = GetComponent<GameObject>();
        sr = GetComponent<SpriteRenderer>();
        sb = GetComponentInParent<SpeedBoost>();

        sb.OnBuffGained += GetBuff;
    }
    private void GetBuff()
    {
        StopAllCoroutines();
        StartCoroutine(blink());
    }
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //if(currentTime < 0) 
        //{
        //    return;
        //}
        //currentTime -= Time.deltaTime;
    }

    private IEnumerator blink()
    {
       Color solid = sr.color;
       solid.a = 1f;
       Color alpha = sr.color;
       alpha.a = 0f;
       float delay = .5f;

        while (true)
        {
            if (sb.currentTime < 4f && sb.currentTime > 0f)
            {
                Debug.Log("blink");
               sr.color = solid;
               yield return new WaitForSeconds(delay);
               sr.color = alpha;
               yield return new WaitForSeconds(delay);
            }
            yield return null;
            Debug.Log("not blink");
        }
        
       
    }
}
