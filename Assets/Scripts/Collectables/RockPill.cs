using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPill : MonoBehaviour
{
    [SerializeField] public GameObject objs1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator YieldSeven()
    {
 
        yield return new WaitForSeconds(7);
 
    }
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        print("-----------------------------------" + objs1.gameObject.name);
        objs1.SetActive(false);
      //  Invoke("nothing", 7f);
       // objs1.SetActive(true);

    }
    // Update is called once per frame
    void nothing()
    {
        
    }
}
