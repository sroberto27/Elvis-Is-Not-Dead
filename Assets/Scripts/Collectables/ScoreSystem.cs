using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject score;
    public GameObject distanceScreem;
    public static int realScore;

    // Update is called once per frame
    void Start()
    {
        realScore = 0;

    }
    void Update()
    {
        score.GetComponent<Text>().text = "Score: " + realScore;
        if(PlayerMove.distance>= 0)
        distanceScreem.GetComponent<Text>().text ="Distance: "+ (int)(PlayerMove.distance);



    }


}
