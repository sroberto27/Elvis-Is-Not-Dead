using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjNear : MonoBehaviour
{
    public static Collider[] objs;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Collider[] getObjNear(float rad)
    {
        objs = Physics.OverlapSphere(this.transform.position, rad);
        foreach (var obj in objs)
        {
            print(obj.gameObject.name);
        }

            return objs;
    }
    // Update is called once per frame
    void Update()
    {
        getObjNear(3);   
    }
}
