using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillsObstacles : MonoBehaviour
{

    [SerializeField] GameObject pill;
    // Start is called before the first frame update
    public  void setPill()
    {
        int rad1 = Random.Range(1,7);
        int rad2 = Random.Range(1, 7);
        int dice = rad1 + rad2;
        if (dice == 7 || dice == 12)
        {
            pill.transform.position = new Vector3(Random.Range(-4, 5), 1.33f, this.transform.position.z + Random.Range(-20, 0));
            pill.SetActive(true);
        }
        else
        {
            //pill.transform.position = new Vector3(Random.Range(-4, 5), 1.33f, this.transform.position.z + Random.Range(-20, 21));
            pill.SetActive(false);
        }
    }
    void Awake()
    {
        setPill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
