using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangeColision : MonoBehaviour
{
    public int healh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        transform.GetChild(0).GetComponent<PlayerSkript>().manageCollisions(hit);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
            healh--;
       
    }


}

