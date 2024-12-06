using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleFrame : MonoBehaviour
{
    //public float duration;
    private SpeedBoost sb;

    void Awake()
    {
        sb = FindObjectOfType<SpeedBoost>();    
    }

    void Update()
    {
        if(sb.isProtected == true)
        {
            deactivateCollider();
        }
        else
        {
            activateCollider();
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

   /* private IEnumerator blink()
    {
        yield return new WaitForSeconds(duration);
       
        activateCollider();
    }*/

}
