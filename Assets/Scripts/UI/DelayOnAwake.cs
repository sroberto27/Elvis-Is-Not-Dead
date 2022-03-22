using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayOnAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("nothing", 5f);
    }
    private void nothing()
    {
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
