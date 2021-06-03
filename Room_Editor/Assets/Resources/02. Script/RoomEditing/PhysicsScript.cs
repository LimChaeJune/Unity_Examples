using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;    


    // Update is called once per frame
    void Update()
    {
        RaycastHit hitinfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(this.transform.position, this.transform.forward, out hitinfo, 10f))
            {
                if (hitinfo.transform.tag == "Player")
                {
                    Instantiate(Bullet, transform.position, Quaternion.LookRotation(hitinfo.transform.position - transform.position));
                }
            }
        }
    }
}
