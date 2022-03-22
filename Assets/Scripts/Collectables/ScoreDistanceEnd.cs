using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDistanceEnd : MonoBehaviour
{
    public GameObject score;
    public GameObject distanceScreem;


    // Update is called once per frame
    void Start()
    {
       

    }
    void Update()
    {
        score.GetComponent<TextMeshProUGUI>().text = "Score: " + ScoreSystem.realScore;
        if (PlayerMove.distance >= 0)
            distanceScreem.GetComponent<TextMeshProUGUI>().text = "Distance: " + (int)(PlayerMove.distance);



    }


}

