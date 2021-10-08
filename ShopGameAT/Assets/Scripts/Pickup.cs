using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject Base;
    public GameObject Package;
    public GameObject EDrink;
    public GameObject Perfume;



    void Start()
    {
        Base.gameObject.SetActive(true);
        Package.gameObject.SetActive(false);
        EDrink.gameObject.SetActive(false);
        Perfume.gameObject.SetActive(false);

    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Package")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Base.gameObject.SetActive(false);
                Package.gameObject.SetActive(true);
                EDrink.gameObject.SetActive(false);
                Perfume.gameObject.SetActive(false);

                

            }
        }

        if (collision.gameObject.tag == "EDrink")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Base.gameObject.SetActive(false);
                Package.gameObject.SetActive(false);
                EDrink.gameObject.SetActive(true);
                Perfume.gameObject.SetActive(false);

                
            }
        }

        if (collision.gameObject.tag == "Perfume")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Base.gameObject.SetActive(false);
                Package.gameObject.SetActive(false);
                EDrink.gameObject.SetActive(false);
                Perfume.gameObject.SetActive(true);

                
                
            }
        }

        
    }
}
