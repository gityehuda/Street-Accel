using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    private CarDriving cd;
    public TMP_Text text;

    // Start is called before the first frame update
    void Awake()
    {
        cd = FindObjectOfType<CarDriving>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = cd.coin.ToString();
    }
}
