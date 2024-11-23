using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundContainer : MonoBehaviour
{
    public Sprite[] images;
    public SpriteRenderer[] sr;
    private float timer = 0;
    private int index;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            index++;
            if(index > 2)
            {
                index = 0;
            }
            timer = 0;
        }
    }

    public void ChangeImage(SpriteRenderer sr)
    {
        //sr[0].sprite = images[index];
        //sr[1].sprite = images[index];
        sr.sprite = images[index];
    }
}
