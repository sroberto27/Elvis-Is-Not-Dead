using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    public AudioSource crashFX;
    public Animator elvisAnimated;
    GameObject coins;
    public GameOver over;
    private void endGame()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMove.lrSpeed=0;
        //cam back 
        // PlayerMove.elvisPublic.transform.GetChild(0).gameObject.transform.position = new Vector3(0, 3f, -3 + PlayerMove.elvisPublic.transform.GetChild(0).gameObject.transform.position.z);
        crashFX.Play();
            elvisAnimated.SetBool("crashed", true);
        //  over.Setup();
        PlayerMove.Speed = 0;
        //StartCoroutine(Sec3());
        //SceneManager.LoadScene("end");
        Invoke("callEnd", 3.0f);

    }
    private void callEnd()
    {
        SceneManager.LoadScene("end");
    }
    IEnumerator Sec3()
    {
      
        yield return new WaitForSeconds(3);
       
    }

}
