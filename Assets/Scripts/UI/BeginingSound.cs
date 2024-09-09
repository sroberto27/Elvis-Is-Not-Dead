using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginingSound : MonoBehaviour
{
    public AudioSource Sound1;
    public AudioSource Sound2;
    bool hasPlayed_1 = false;
    bool hasPlayed_2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
   
private void nothing()
{

}
private void playing()
    {


        if (!hasPlayed_1)
        {
            Sound1.Play();
            hasPlayed_1 = true;
            //Smae=t
        }
        if (hasPlayed_1 && !hasPlayed_2 && !Sound1.isPlaying)
        {

            Sound2.PlayDelayed(0.6f);
            hasPlayed_2 = true;
        }
    }
    IEnumerator sec7()
    {
        yield return new WaitForSeconds(7);
    }
    // Update is called once per frame
    void Update()
    {
        playing();
    }
}
