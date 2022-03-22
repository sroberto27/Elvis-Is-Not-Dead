using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
  // [SerializeField] PlayerMove player;
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void PlayButton()
    {
      //  player.lrSpeed = 2;
        SceneManager.LoadScene("SampleScene");
    }

}