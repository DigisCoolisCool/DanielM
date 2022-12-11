using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkript : MonoBehaviour
{
    Camera PlayerCamera;
    Ray RayFromPlayer;
    RaycastHit hit;
    public GameObject sparkles;
    public int ammo = 1000;
    public AudioSource lasersaund;
    public ParticleSystem LaserSmatch;
   //public AudioSource AmmoPickUp;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        RayFromPlayer=PlayerCamera.ScreenPointToRay(new Vector3(Screen.width /2,Screen.height/2,0));
        Debug.DrawRay(RayFromPlayer.origin, RayFromPlayer.direction * 100, Color.red);

        if(Input.GetKeyDown(KeyCode.F) && ammo>0)

        
        {
            if(Physics.Raycast(RayFromPlayer,out hit, 100))

            {
                print("The objects is" + hit.collider.gameObject.name + "in front of player!");
                Vector3 positionofImpact;
                positionofImpact = hit.point;
                Instantiate(sparkles, positionofImpact, Quaternion.identity);
                GameObject objectTargeted;
                if (hit.collider.gameObject.tag == "Target")
                {
                    objectTargeted = hit.collider.gameObject;
                    objectTargeted.GetComponent<ManegMpc>().GotHit();

            }
            ammo--;
            print("you have" + ammo + "ammo left!");
            lasersaund.Play();
            LaserSmatch.Play();
        }

        
        
            

    }
    }


    public void manageCollisions(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject.tag=="ammo_gun")
        {
            ammo += 5;
            if (ammo > 100) ammo = 100;
            Destroy(hit.collider.gameObject);
            //AmmoPickUp.Play();



        }



    }
}


