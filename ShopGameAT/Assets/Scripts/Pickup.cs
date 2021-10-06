using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject Base;
    public GameObject Package;


    void Start()
    {
        Base.gameObject.SetActive(true);
        Package.gameObject.SetActive(false);

    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Package")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Base.gameObject.SetActive(false);
                Package.gameObject.SetActive(true);

                Destroy(collision.gameObject);
            }
        }
    }
}
