using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
   
{
    public Transform target;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, time);
    }
}
