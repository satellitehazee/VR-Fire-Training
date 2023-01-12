using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMPro.TMP_Text TimerText;
    private float second;
    // Start is called before the first frame update
    void Start()
    {
        second = 0;
    }

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        TimerText.text = ((int)second).ToString();
    }
}
