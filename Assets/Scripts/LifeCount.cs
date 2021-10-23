using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public static int liveAmount;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        liveAmount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Lives: " + liveAmount;
    }
}
