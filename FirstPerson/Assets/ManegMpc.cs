using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManegMpc : MonoBehaviour
{
    public int health;
    public GameObject lastSmoke;
    // Start is called before the first frame update
    void Start()
    {
        health = 15;
    }

        public void GotHit()
    {
        health -= 5;
    }
    public void DestroyNPC()
    {
        GameObject Smoke = Instantiate(lastSmoke,transform.position,Quaternion.identity);
        Destroy(Smoke, 3);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
         if(health<=0)
        {
            DestroyNPC();
        }
    }
}

