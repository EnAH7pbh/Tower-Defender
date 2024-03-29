﻿using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Slider slide;
    public Text coin;
    public Text time;
    float countDown = 90;
    float timer = 0;
    // Start is called before the first frame update
    void Start () {
        Data.coin = 0;
        time.text = "01:30";
    }

    // Update is called once per frame
    void Update () {
        if (Data.coin < 800) {
            Data.coin += 50 * Time.deltaTime;
            slide.value = Data.coin;
            coin.text = Data.coin.ToString ("000");
        }
        timer += Time.deltaTime;
        if (timer > 1f) {
            timer = 0;
            if (countDown > 0) {
                countDown--;
                string minutes = Mathf.Floor (countDown / 60).ToString ("00");
                string seconds = Mathf.Floor (countDown % 60).ToString ("00");
                time.text = minutes + ":" + seconds;
            }else{
                Data.isGameOver = true;
                Data.isCompleted = false;
            }
        }
    }
}