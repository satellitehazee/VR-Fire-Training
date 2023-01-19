using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMPro.TMP_Text TimerText;
    private float second;
    private float maxSecond = 120;
    public FireRandomizer Fire;
    // Start is called before the first frame update
    void Start()
    {
        second = maxSecond;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fire.isClear == false)
        {
            second -= Time.deltaTime;
            if (second > 0)
            {
                TimerText.text = ((int)second).ToString();
            }
            else
            {
                TimerText.text = "Evakuasi!";
            }
        } else
        {
            TimerText.text = "Selesai " + ((int)maxSecond - (int)second).ToString() + " !";
        }
    }
}
