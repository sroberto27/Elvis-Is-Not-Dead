using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseHomeB : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update

    public void home()
    {
        Time.timeScale = 1F;
        SceneManager.LoadScene("begin");
    }
    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume()
    {
        PlayerMove.lrSpeed = 2;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
  
}
